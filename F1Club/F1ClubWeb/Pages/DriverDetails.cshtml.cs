using DAL.Driver_DAOs_classes;
using DAL;
using LL.Driver_related;
using LL.GP_related;
using LL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class DriverDetailsModel : PageModel
    {
        DriverManager driverManager = new DriverManager(new DriverDAO());
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        public Driver Driver { get; set; }
        public int Wins { get; set; }

        public void OnGet(int driverId)
        {
            Driver = driverManager.GetDriverByID(driverId);
            Wins = gpResultManager.GetDriverWinsById(driverId);
        }

    }
}
