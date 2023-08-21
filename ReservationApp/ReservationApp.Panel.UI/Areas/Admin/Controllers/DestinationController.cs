using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    public class DestinationController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
