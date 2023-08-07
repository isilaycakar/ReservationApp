using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.Panel.UI.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EFDestinationDal());
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Destinations.ToList();
            return View(values);
        }

        public IActionResult DestinationDetails(int id)
        {
            var values = dm.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
