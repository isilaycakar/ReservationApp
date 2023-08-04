using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.ViewComponents.Default
{
    public class Statistic: ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = 285;
            return View();
        }
    }
}
