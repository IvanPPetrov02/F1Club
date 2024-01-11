using DAL;
using DAL.Driver_DAOs_classes;
using DAL.GP_DAOs_classes;
using DAL.Team_DAOs_classes;
using LL;
using LL.Championship_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class ChampionshipsModel : PageModel
    {
        ChampionshipManager championshipManager = new ChampionshipManager(new GPResultDAO(), new DriverDAO(), new TeamDAO(), new GPDAO());

        [BindProperty]
        public List<Championship> Championships { get; set; }

        public void OnGet()
        {
            Championships = championshipManager.GetAllChampionships();
        }
    }
}
