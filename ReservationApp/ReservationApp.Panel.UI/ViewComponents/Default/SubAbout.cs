using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.ViewComponents.Default
{
    public class SubAbout: ViewComponent
    {
        SubAboutManager sbm = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = sbm.TGetAll();
            return View(values);
        }
    }
}
