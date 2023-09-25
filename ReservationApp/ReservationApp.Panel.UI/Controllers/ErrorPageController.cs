using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {

            return View();
        }
    }
}
