using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class GuideController : Controller
    {
        private readonly IGuideService guideService;
        public GuideController(IGuideService guideService)
        {
            this.guideService = guideService;
        }

        public IActionResult Index()
        {
            var values = guideService.TGetAll();
            return View(values);
        }

        public IActionResult AddGuide()
        {

            return View();

        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            guideService.TAdd(guide);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }

        public IActionResult EditGuide(int id)
        {
            var values = guideService.TGetByID(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            guideService.TUpdate(guide);
            return RedirectToAction("Index");

        }

        public IActionResult ChangeToTrue(int id    ) 
        {
            return RedirectToAction("Index");

        }

        public IActionResult ChangeToFalse(int id)
        {
            return RedirectToAction("Index");

        }
    }
}
