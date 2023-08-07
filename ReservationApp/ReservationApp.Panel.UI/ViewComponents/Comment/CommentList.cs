using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Concrete;
using ReservationApp.DataAccessLayer.Entity_Framework;

namespace ReservationApp.Panel.UI.ViewComponents.Comment
{
    public class CommentList:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentDal());
        public IViewComponentResult Invoke(int Id)
        {
            var values = cm.TGetDestinationById(Id);
            return View(values);
        }
    }
}
