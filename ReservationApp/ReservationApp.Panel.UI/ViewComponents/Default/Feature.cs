using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.ViewComponents.Default
{
    public class Feature: ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EFFeatureDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = fm.TGetAll();
            return View(values);
        }
    }
}
