using Microsoft.EntityFrameworkCore;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        Context context = new Context();
        public List<Comment> GetListCommetWithDestination()
        {
           return context.Comments.Include(x=> x.Destination).ToList();
        }
    }
}
