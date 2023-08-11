using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
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
        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            commentDal.Create(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetAll()
        {
            throw new NotImplementedException();
        }
        public List<Comment> TGetDestinationById(int Id)
        {
            return commentDal.GetListByFilter(x=>x.DestinationID == Id);
        }
        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
