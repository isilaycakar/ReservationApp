using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.ViewComponents.Default
{
    public class Testimonial: ViewComponent
    {
        TestimonialManager tm = new TestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = tm.TGetAll();
            return View(values);
        }
    }
}
