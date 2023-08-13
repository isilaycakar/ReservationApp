using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.Areas.Member.Controllers
{
    [Area("Member")]
    public class CommentController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
