using DAL;
using DAL.Car_DAOs_classes;
using DAL.Driver_DAOs_classes;
using DAL.GP_DAOs_classes;
using LL;
using LL.Driver_related;
using LL.GP_related;
using LL.Team_related;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace F1ClubWeb.Pages
{
    public class GPDetailsModel : PageModel
    {
        GPManager gpManager = new GPManager(new GPDAO());
        DriverManager driverManager = new DriverManager(new DriverDAO());
        GPResultManager gpResultManager = new GPResultManager(new GPResultDAO());
        CarManager carManager = new CarManager(new CarDAO());
        GPPredictionAlgorithm gpPredictionAlgorithm = new GPPredictionAlgorithm();
        

        [BindProperty]
        public List<(Driver driver, int predictedPosition)> PodiumPrediction { get; set; }

        [BindProperty]
        public GP GP { get; set; }

        [BindProperty]
        public DateOnly Date { get; set; }

        [BindProperty]
        public List<GPResult> PastResults { get; set; }

        [BindProperty]
        public bool HasResults { get; set; }

        public void OnGet(int gpid)
        {
            Date = DateOnly.FromDateTime(DateTime.Now);
            GP = gpManager.GetGPByID(gpid);
            HasResults = gpResultManager.GPHasResults(gpid);

            if (HasResults)
            {
                PastResults = gpResultManager.GetAllGPResultsByGPID(gpid);
            }
            else
            {
                PodiumPrediction = gpPredictionAlgorithm.PredictPodium(GP, gpResultManager.GetAllGPResults(), carManager.GetAllCars(), driverManager.GetAllDrivers());
            }
        }
    }
}
