using DAL.GP_DAOs_classes;
using LL;
using LL.GP_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class GrandPrixModel : PageModel
    {
        GPManager gpManager = new GPManager(new GPDAO());

        [BindProperty]
        public List<GP> GrandPrixes { get; set; }

        [BindProperty]
        public DateOnly Date { get; set; }
        public void OnGet()
        {
            GrandPrixes = gpManager.GetAllGPs();
            Date = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
