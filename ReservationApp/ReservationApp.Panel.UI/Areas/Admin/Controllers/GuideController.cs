using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.BusinessLayer.ValidationRules;
using ReservationApp.EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide/[action]")]
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
            GuideValidator validationRules = new GuideValidator();
            FluentValidation.Results.ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                guideService.TAdd(guide);
                return RedirectToAction("Index", "Guide", new { area = "Admin" });
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

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

        public IActionResult ChangeToTrue(int id)
        {
            guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }

        public IActionResult ChangeToFalse(int id)
        {
            guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }
    }
}
