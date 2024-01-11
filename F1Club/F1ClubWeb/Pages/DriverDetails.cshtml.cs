using DAL.Driver_DAOs_classes;
using DAL;
using LL.Driver_related;
using LL.GP_related;
using LL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DAL.GP_DAOs_classes;
using DAL.Team_DAOs_classes;

namespace F1ClubWeb.Pages
{
    public class DriverDetailsModel : PageModel
    {
        DriverManager driverManager = new DriverManager(new DriverDAO());
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        ChampionshipManager championshipManager = new ChampionshipManager(new GPResultDAO(), new DriverDAO(), new TeamDAO(), new GPDAO());

        [BindProperty]
        public Driver Driver { get; set; }

        [BindProperty]
        public int Wins { get; set; }

        [BindProperty]
        public List<(int Season, int Points)> SeasonPoints { get; set; }

        [BindProperty]
        public int ChampionshipWins { get; set; }

        public void OnGet(int driverId)
        {
            Driver = driverManager.GetDriverByID(driverId);
            Wins = gpResultManager.GetDriverWinsById(driverId);
            ChampionshipWins = championshipManager.GetChampionshipTitlesByDriverID(driverId);

            SeasonPoints = gpResultManager.GetDriverPointsForAllSeasons(driverId);
        }

    }
}
