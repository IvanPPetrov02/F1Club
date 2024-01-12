using LL.Driver_related;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.GP_related
{
    public class GPResultManager
    {
        IGPResultDAO gpResultDAO;

        public GPResultManager(IGPResultDAO gpResultDAO)
        {
            this.gpResultDAO = gpResultDAO;
        }

        private static List<GPResult>? GPResults = new List<GPResult>();

        private void PopulateIfEmpty()
        {
            if (GPResults.Any())
            {
                return;
            }
            else
            {
                RefreshGPsFromDatabase();
            }
        }
        private void RefreshGPsFromDatabase()
        {
            GPResults?.Clear();

            foreach (GPResult GPResult in gpResultDAO.GetAllGPResults())
            {
                GPResults?.Add(GPResult);
            }
        }

        public void DeleteGPResult(GPResult GPResult)
        {
            try
            {
                gpResultDAO.DeleteGPResult(GPResult.GP.ID, GPResult.Driver.ID);

                PopulateIfEmpty();
                GPResult GPResultToRemove = GPResults?.FirstOrDefault(gpResult => gpResult.GP == GPResult.GP && gpResult.Driver == GPResult.Driver);
                if (GPResultToRemove != null)
                {
                    GPResults.Remove(GPResultToRemove);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<GPResult> GetAllGPResults()
        {
            PopulateIfEmpty();
            return GPResults;
        }

        public List<GPResult> GetAllGPResultsByGPID(int gpid)
        {
            RefreshGPsFromDatabase();
            return GPResults?.Where(gpResult => gpResult.GP.ID == gpid).ToList();
        }

        public void SetGPResult(List<GPResult> GPResult)
        {
            try
            {
                var sortedGPResults = GPResult.OrderBy(gp => gp.FinishTime).ToList();

                int position = 1;
                foreach (GPResult gpResult in sortedGPResults)
                {
                    gpResult.Place = position++;

                    gpResultDAO.SetGPResult(gpResult);
                    GPResults.Add(gpResult);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void UpdateGPResult(List<GPResult> GPResults)
        {
            try
            {
                PopulateIfEmpty();
                foreach (GPResult gpResult in GPResults)
                {
                    gpResultDAO.UpdateGPResult(gpResult);

                    GPResult existingGPResult = GPResults?.First(result => result.GP == gpResult.GP && result.Driver == gpResult.Driver);
                    if (existingGPResult != null)
                    {
                        existingGPResult.Place = gpResult.Place;
                        existingGPResult.LapTime = gpResult.LapTime;
                        existingGPResult.FinishTime = gpResult.FinishTime;
                        existingGPResult.MaxSpeed = gpResult.MaxSpeed;
                        existingGPResult.AvgSpeed = gpResult.AvgSpeed;
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public GPResult GetBestLapTime(int GPID)
        {
            PopulateIfEmpty();
            List<GPResult> gPResults = GetAllGPResultsByGPID(GPID);
            return gPResults.Find(gpResult => gpResult.LapTime == gPResults.Min(gpResult => gpResult.LapTime));
        }

        public GPResult GetBestFinishTime(int GPID)
        {
            PopulateIfEmpty();
            List<GPResult> gPResults = GetAllGPResultsByGPID(GPID);
            return gPResults.Find(gpResult => gpResult.FinishTime == gPResults.Min(gpResult => gpResult.FinishTime));
        }

        public GPResult GetBestAvgSpeed(int GPID)
        {
            PopulateIfEmpty();
            List<GPResult> gPResults = GetAllGPResultsByGPID(GPID);
            return gPResults.Find(gpResult => gpResult.AvgSpeed == gPResults.Max(gpResult => gpResult.AvgSpeed));
        }

        public GPResult GetBestMaxSpeed(int GPID)
        {
            PopulateIfEmpty();
            List<GPResult> gPResults = GetAllGPResultsByGPID(GPID);
            return gPResults.Find(gpResult => gpResult.MaxSpeed == gPResults.Max(gpResult => gpResult.MaxSpeed));
        }

        public Dictionary<int, (string FullName, int Wins)> GetAllDriversWins()
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            Dictionary<int, (string FullName, int Wins)> driverWins = new Dictionary<int, (string, int)>();

            foreach (GPResult gpResult in gpResults)
            {
                if (gpResult.Place == 1)
                {
                    int driverId = gpResult.Driver.ID;

                    if (driverWins.ContainsKey(driverId))
                    {
                        driverWins[driverId] = (gpResult.Driver.FullName, driverWins[driverId].Wins + 1);
                    }
                    else
                    {
                        driverWins.Add(driverId, (gpResult.Driver.FullName, 1));
                    }
                }
            }
            return driverWins;
        }

        public int GetDriverWinsById(int driverId)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            int wins = 0;

            foreach (GPResult gpResult in gpResults)
            {
                if (gpResult.Place == 1 && gpResult.Driver.ID == driverId)
                {
                    wins++;
                }
            }
            return wins;
        }

        public List<(int Season, int Points)> GetDriverPointsForAllSeasons(int driverId)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            List<int> seasons = SeasonsPlayedByDriver(driverId);
            List<(int Season, int Points)> seasonPoints = new List<(int Season, int Points)>();

            foreach (int season in seasons)
            {
                int points = 0;
                foreach (GPResult gpResult in gpResults)
                {
                    if (gpResult.Driver.ID == driverId && gpResult.GP.DateOfGP.Year == season)
                    {
                        points += GetPointsBasedOnPlace(gpResult.Place);
                    }
                }
                seasonPoints.Add((season, points));
            }

            return seasonPoints;
        }


        private int GetPointsBasedOnPlace(int place)
        {
            switch (place)
            {
                case 1: return 25;
                case 2: return 18;
                case 3: return 15;
                case 4: return 12;
                case 5: return 10;
                case 6: return 8;
                case 7: return 6;
                case 8: return 4;
                case 9: return 2;
                case 10: return 1;
                default: return 0;
            }
        }

        public List<int> SeasonsPlayedByDriver(int driverid)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            List<int> seasons = new List<int>();

            foreach (GPResult gpResult in gpResults)
            {
                if (gpResult.Driver.ID == driverid)
                {
                    if (!seasons.Contains(gpResult.GP.DateOfGP.Year))
                    {
                        seasons.Add(gpResult.GP.DateOfGP.Year);
                    }
                }
            }

            return seasons;
        }

        private Team GetTeamById(int teamId)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            return gpResults.First(gpResult => gpResult.Driver.Team.ID == teamId).Driver.Team;
        }

        public List<(int Rank, Team Team, double AveragePosition)> GetTeamsAveragePositions()
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            Dictionary<int, List<int>> teamPositions = new Dictionary<int, List<int>>();

            foreach (GPResult gpResult in gpResults)
            {
                int teamId = gpResult.Driver.Team.ID;
                if (!teamPositions.ContainsKey(teamId))
                {
                    teamPositions[teamId] = new List<int>();
                }
                teamPositions[teamId].Add(gpResult.Place);
            }

            var teamAverages = teamPositions.Select(tp =>
                new {
                    TeamId = tp.Key,
                    AveragePosition = tp.Value.Average()
                });

            var rankedTeams = teamAverages.OrderBy(ta => ta.AveragePosition)
                                          .Select((ta, index) =>
                                              (Rank: index + 1, Team: GetTeamById(ta.TeamId), AveragePosition: ta.AveragePosition))
                                          .ToList();

            return rankedTeams;
        }

        public double GetTeamAveragePositionById(int teamId)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            List<int> teamPositions = new List<int>();

            foreach (GPResult gpResult in gpResults)
            {
                if (gpResult.Driver.Team.ID == teamId)
                {
                    teamPositions.Add(gpResult.Place);
                }
            }

            if (!teamPositions.Any())
            {
                return -1;
            }

            double averagePosition = teamPositions.Average();

            return averagePosition;
        }

        public bool GPHasResults(int gpid)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            return gpResults.Any(gpResult => gpResult.GP.ID == gpid);
        }
    }
}
