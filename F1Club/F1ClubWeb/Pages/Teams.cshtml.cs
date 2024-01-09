using DAL.Team_DAOs_classes;
using LL;
using LL.Team_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class TeamsModel : PageModel
    {
        TeamManager teamManager = new TeamManager(new TeamDAO());
        [BindProperty]
        public List<Team> Teams { get; set; }
        public void OnGet()
        {
            Teams = teamManager.GetAllTeams();
        }
    }
}
