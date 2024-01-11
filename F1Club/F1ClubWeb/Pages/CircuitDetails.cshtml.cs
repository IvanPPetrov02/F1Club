using DAL.GP_DAOs_classes;
using LL;
using LL.GP_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class CircuitDetailsModel : PageModel
    {
        CircuitManager circuitManager = new CircuitManager(new CircuitDAO());

        [BindProperty]
        public Circuit Circuit { get; private set; }

        public void OnGet(int id)
        {
            Circuit = circuitManager.GetCircuitByID(id);
        }
    }
}
