using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Panel.UI.ViewComponents.MemberDashboard
{
    public class _platformSettings: ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
