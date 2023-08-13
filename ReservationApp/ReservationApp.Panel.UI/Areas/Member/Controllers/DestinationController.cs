using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetAll();
            return View(values);
        }
    }
}
