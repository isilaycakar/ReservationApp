using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.ViewComponents.Default
{
    public class IndexPopularDestinations: ViewComponent
    {
        DestinationManager dm = new DestinationManager(new EFDestinationDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = c.Destinations.Take(8).ToList();
            //var values = dm.TGetAll();
            return View(values);
        }
    }
}
