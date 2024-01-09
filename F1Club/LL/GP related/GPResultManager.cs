using LL.Driver_related;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL.GP_related
{
    public class GPResultManager:IGPResultPrediction
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

        private List<GPResult> GetAllGPResults()
        {
            PopulateIfEmpty();
            return GPResults;
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

        public List<Driver> PredictPodium(List<Driver> drivers)
        {
            PopulateIfEmpty();
            List<GPResult> gpResults = GetAllGPResults();
            List<Driver> podium = new List<Driver>();

            foreach (GPResult gpResult in gpResults)
            {
                if (gpResult.Place <= 3)
                {
                    podium.Add(gpResult.Driver);
                }
            }

            return podium;
        }

    }
}
