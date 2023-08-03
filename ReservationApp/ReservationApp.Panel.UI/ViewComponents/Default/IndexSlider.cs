using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.ViewComponents.Default
{
    public class IndexSlider: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
