using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.Panel.UI.ViewComponents.MemberDashboard
{
    public class _ProfileInformation: ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.NameSurname;
            ViewBag.phone = values.PhoneNumber;
            ViewBag.mail = values.Email;
            return View();

        }
    }
}
