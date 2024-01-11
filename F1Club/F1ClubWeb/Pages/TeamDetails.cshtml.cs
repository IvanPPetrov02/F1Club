using DAL;
using DAL.Driver_DAOs_classes;
using DAL.GP_DAOs_classes;
using DAL.Team_DAOs_classes;
using LL;
using LL.Driver_related;
using LL.GP_related;
using LL.Team_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class TeamDetailsModel : PageModel
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        DriverManager driverManager = new DriverManager(new DriverDAO());
        ChampionshipManager championshipManager = new ChampionshipManager(new GPResultDAO(), new DriverDAO(), new TeamDAO(), new GPDAO());

        [BindProperty]
        public Team Team { get; set; }

        [BindProperty]
        public List<Driver> Drivers { get; set; }

        [BindProperty]
        public double TeamAveragePositions { get; set; }

        [BindProperty]
        public int Wins { get; set; }

        public void OnGet(int id)
        {
            Team = teamManager.GetTeamByID(id);
            Drivers = driverManager.GetDriversByTeamID(id);
            TeamAveragePositions = gpResultManager.GetTeamAveragePositionById(id);
            TeamAveragePositions = Math.Round(TeamAveragePositions, 2);
            Wins = championshipManager.GetChampionshipTitlesByTeamID(id);
        }
    }
}
