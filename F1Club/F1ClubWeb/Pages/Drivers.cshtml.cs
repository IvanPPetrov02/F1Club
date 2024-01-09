using DAL.Driver_DAOs_classes;
using LL;
using LL.Driver_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class DriversModel : PageModel
    {
        DriverManager driverManager = new DriverManager(new DriverDAO());

        [BindProperty]
        public List<Driver> Drivers { get; set; }
        
        public void OnGet()
        {
            Drivers = driverManager.GetAllDrivers();
        }
    }
}
