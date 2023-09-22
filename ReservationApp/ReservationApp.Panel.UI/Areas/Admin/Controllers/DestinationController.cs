using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            this.destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = destinationService.TGetAll();
            return View(values);
        }
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            destinationService.TAdd(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });

        }
        public IActionResult DeleteDestination(int Id)
        {
            var values = destinationService.TGetByID(Id);
            destinationService.TDelete(values);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
        public IActionResult UpdateDestination(int Id)
        {
            var values = destinationService.TGetByID(Id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
