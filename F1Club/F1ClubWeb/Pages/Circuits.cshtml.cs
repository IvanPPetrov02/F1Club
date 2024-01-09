using DAL.GP_DAOs_classes;
using LL;
using LL.GP_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class CircuitsModel : PageModel
    {
        CircuitManager circuitManager = new CircuitManager(new CircuitDAO());

        [BindProperty]
        public List<Circuit> Circuits { get; set; }
        public void OnGet()
        {
            Circuits = circuitManager.GetAllCircuits();
        }
    }
}
