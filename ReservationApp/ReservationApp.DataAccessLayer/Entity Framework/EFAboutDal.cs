using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFAboutDal: GenericRepository<About>, IAboutDal
    {
    }

}
