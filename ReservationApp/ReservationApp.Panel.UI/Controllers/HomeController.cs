using Microsoft.AspNetCore.Mvc;
using ReservationApp.Panel.UI.Models;
using System.Diagnostics;

namespace ReservationApp.Panel.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime d = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d + "Index sayfası çağırıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy sayfası çağırıldı");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}