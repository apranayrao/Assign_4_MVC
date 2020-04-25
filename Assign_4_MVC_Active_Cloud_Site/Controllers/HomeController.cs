using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assign_4_MVC_Active_Cloud_Site.Models;
using Assign_4_MVC_Active_Cloud_Site.APIHandlerManager;


namespace Assign_4_MVC_Active_Cloud_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Products()
        {
            APIHandler webHandler = new APIHandler();
            Rootobject results = webHandler.GetData();

            return View(results);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ViewResult Chart()
        {
            string[] ChartLabels = new string[] { "Vit/Min/Prot/Unconv Diet", "Nuts/Edible Seed", "Soft Drink/Water", "Fruit/Fruit Prod", "Bakery Prod/Dough/Mix/Icing","Cereal Prep/Breakfast Food","Vegetables/Vegetable Products","Fishery/Seafood Prod","Dressing/Condiment","Spices, Flavors And Salts","Prep Salad Prod" };
            string[] ChartColors = new string[] { "#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850", "#1f5ea5", "#2e5ea2", "#4e5ea2", "#5e5ea2", "#6e5ea2", "#9e5ea2" };
            int[] ChartData = new int[] { 15, 10, 7, 5, 5, 4, 3, 2, 1, 1, 1 };

            ChartModel Model = new ChartModel
            {
                ChartType = "bar",
                Labels = String.Join(",", ChartLabels.Select(d => "'" + d + "'")),
                Colors = String.Join(",", ChartColors.Select(d => "\"" + d + "\"")),
                Data = String.Join(",", ChartData.Select(d => d)),
                Title = "Distribution of Food Items by Industry Name"
            };

            return View(Model);
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
