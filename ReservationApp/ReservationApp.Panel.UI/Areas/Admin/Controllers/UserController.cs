using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly IAppUserService appUserService;

        public UserController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var values = appUserService.TGetAll();
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = appUserService.TGetByID(id);
            appUserService.TDelete(values);
            return View("Index");
        }

        public IActionResult EditUser(int id)
        {
            var values = appUserService.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            appUserService.TGetAll();
            return View();
        }

        public IActionResult DestinationUser(int id)
        {
            appUserService.TGetAll();
            return View();
        }
    }
}
