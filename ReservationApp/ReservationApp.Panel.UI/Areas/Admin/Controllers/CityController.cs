using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;
using ReservationApp.Panel.UI.Areas.Admin.Models;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService destinationService;
        public CityController(IDestinationService destinationService)
        {
            this.destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(destinationService.TGetAll());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(EntityLayer.Concrete.Destination destination)
        {
            destination.Status = true;
            destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination); 
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = destinationService.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var values = destinationService.TGetByID(id);
            destinationService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(EntityLayer.Concrete.Destination destination)
        {
            var existingDestination = destinationService.TGetByID(destination.DestinationID);

            if (existingDestination != null)
            {
                // Sadece güncellenen alanları güncelleyin
                existingDestination.City = destination.City;
                existingDestination.PeriodOfStay = destination.PeriodOfStay;

                // Değişiklikleri kaydedin
                destinationService.TUpdate(existingDestination);

                return Json("Güncelleme işlemi yapıldı");
            }
            else
            {
                return Json("Belirtilen destinasyon bulunamadı");
            }
        }
    }
}
