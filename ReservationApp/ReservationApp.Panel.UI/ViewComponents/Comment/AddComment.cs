using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.ViewComponents.Comment
{
    public class AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
