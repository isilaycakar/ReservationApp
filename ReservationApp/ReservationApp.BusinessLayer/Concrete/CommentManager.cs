using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal commentDal;
        Context context = new Context();
        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            commentDal.Create(t);
            context.SaveChanges();
        }

        public void TDelete(Comment t)
        {
            commentDal.Delete(t);
            context.SaveChanges();
        }

        public List<Comment> TGetAll()
        {
            return commentDal.GetAll();
        }
        public List<Comment> TGetDestinationById(int Id)
        {
            return commentDal.GetListByFilter(x=>x.DestinationID == Id);
        }
        public Comment TGetByID(int id)
        {
            return commentDal.GetByID(id);
        }

        public void TUpdate(Comment t)
        {
            commentDal.Update(t);
            context.SaveChanges();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return commentDal.GetListCommetWithDestination();
        }
    }
}
