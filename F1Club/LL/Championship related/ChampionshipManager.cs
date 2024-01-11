using LL.Championship_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LL
{
    public class ChampionshipManager
    {
        IGPResultDAO gpResultDAO;
        IDriverDAO driverDAO;
        ITeamDAO teamDAO;
        IGPDAO gpDAO;

        public ChampionshipManager(IGPResultDAO gpResultDAO, IDriverDAO driverDAO, ITeamDAO teamDAO, IGPDAO gpDAO)
        {
            this.gpResultDAO = gpResultDAO;
            this.driverDAO = driverDAO;
            this.teamDAO = teamDAO;
            this.gpDAO = gpDAO;
        }

        public static List<Championship>? Championships = new List<Championship>();

        private void PopulateIfEmpty()
        {
            if (Championships.Any())
            {
                return;
            }
            else
            {
                CreateChampionshipsFromGPResults();
            }
        }

        public List<Championship> GetAllChampionships()
        {
            PopulateIfEmpty();
            return Championships;
        }

        private void CreateChampionshipsFromGPResults()
        {
            List<GPResult> GPResults = gpResultDAO.GetAllGPResults();

            var groupedResults = GPResults.GroupBy(r => r.GP.DateOfGP.Year);

            foreach (var yearGroup in groupedResults)
            {
                int year = yearGroup.Key;
                var GPsThisYear = GetGPsFromYear(year);

                // Check if results exist for all GPs of the year
                bool allGPsCompleted = GPsThisYear.All(gp => yearGroup.Any(result => result.GP.ID == gp.ID));

                Championship championship = Championships.FirstOrDefault(c => c.Year == year) ?? new Championship
                {
                    Year = year,
                    EndPositions = new List<(int Position, Driver driver)>(),
                    EndTeamPositions = new List<(int Position, Team team)>(),
                    GPs = GPsThisYear
                };

                if (!Championships.Contains(championship))
                {
                    Championships.Add(championship);
                }

                var driverPoints = AggregateDriverPoints(year, yearGroup.ToList());
                var teamPoints = AggregateTeamPoints(year, yearGroup.ToList());

                List<Driver> drivers = driverDAO.GetAllDrivers();
                List<Team> teams = teamDAO.GetAllTeams();

                championship.EndPositions = RankDrivers(driverPoints, drivers);
                championship.EndTeamPositions = RankTeams(teamPoints, teams);

                if (allGPsCompleted)
                {
                    championship.Champion = championship.EndPositions.FirstOrDefault().driver;
                    championship.ChampionTeam = championship.EndTeamPositions.FirstOrDefault().team;
                }
            }

            Championships = Championships.OrderByDescending(c => c.Year).ToList();
        }

        private List<GP> GetGPsFromYear(int year)
        {
            return gpDAO.GetAllGPs().Where(r => r.DateOfGP.Year == year).Select(r => r).Distinct().ToList();
        }


        private Dictionary<int, int> AggregateDriverPoints(int seasonYear, List<GPResult> gpResults)
        {
            var driverPoints = new Dictionary<int, int>();
            foreach (var result in gpResults.Where(r => r.GP.DateOfGP.Year == seasonYear))
            {
                if (!driverPoints.ContainsKey(result.Driver.ID))
                    driverPoints[result.Driver.ID] = 0;
                driverPoints[result.Driver.ID] += GetPointsBasedOnPlaceDrivers(result.Place);
            }
            return driverPoints;
        }
        private List<(int position, Driver driver)> RankDrivers(Dictionary<int, int> driverPoints, List<Driver> drivers)
        {
            return driverPoints.OrderByDescending(kv => kv.Value)
                               .Select(kv => (position: kv.Value, driver: drivers.FirstOrDefault(d => d.ID == kv.Key)))
                               .Select((item, index) => (position: index + 1, item.driver))
                               .ToList();
        }


        private Dictionary<int, int> AggregateTeamPoints(int seasonYear, List<GPResult> gpResults)
        {
            var teamPoints = new Dictionary<int, int>();
            foreach (var result in gpResults.Where(r => r.GP.DateOfGP.Year == seasonYear))
            {
                int teamId = result.Driver.Team.ID;
                if (!teamPoints.ContainsKey(teamId))
                    teamPoints[teamId] = 0;
                teamPoints[teamId] += GetPointsBasedOnPlaceTeams(result.Place);
            }
            return teamPoints;
        }

        private List<(int position, Team team)> RankTeams(Dictionary<int, int> teamPoints, List<Team> teams)
        {
            return teamPoints.OrderByDescending(kv => kv.Value)
                             .Select(kv => (position: kv.Value, team: teams.FirstOrDefault(t => t.ID == kv.Key)))
                             .Select((item, index) => (position: index + 1, item.team))
                             .ToList();
        }


        private int GetPointsBasedOnPlaceDrivers(int place)
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
        private int GetPointsBasedOnPlaceTeams(int place)
        {
            int score = 0;

            if (place <= 2)
            {
                score += 15;
            }
            else if (place <= 5)
            {
                score += 10;
            }
            else if (place <= 10)
            {
                score += 5;
            }
            else
            {
                score += 2;
            }

            return score;
        }

        public Championship GetChampionshipByYear(int year)
        {
            PopulateIfEmpty();
            return Championships.FirstOrDefault(c => c.Year == year);
        }

        public List<int> GetYears()
        {
            PopulateIfEmpty();
            return Championships.Select(c => c.Year).ToList();
        }

        public int GetChampionshipTitlesByDriverID(int id)
        {
            PopulateIfEmpty();
            return Championships.Count(c => c.Champion != null && c.Champion.ID == id);
        }

        public int GetChampionshipTitlesByTeamID(int id)
        {
            PopulateIfEmpty();
            return Championships.Count(c => c.ChampionTeam != null && c.ChampionTeam.ID == id);
        }
    }
}
