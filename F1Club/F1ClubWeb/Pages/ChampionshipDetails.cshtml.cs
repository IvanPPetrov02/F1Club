using DAL.Driver_DAOs_classes;
using DAL.Team_DAOs_classes;
using DAL;
using LL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LL.Championship_related;
using DAL.GP_DAOs_classes;

namespace F1ClubWeb.Pages
{
    public class ChampionshipDetailsModel : PageModel
    {
        ChampionshipManager championshipManager = new ChampionshipManager(new GPResultDAO(), new DriverDAO(), new TeamDAO(), new GPDAO());

        [BindProperty]
        public Championship Championship { get; set; }
        public void OnGet(int year)
        {
            Championship = championshipManager.GetChampionshipByYear(year);
        }
    }
}
