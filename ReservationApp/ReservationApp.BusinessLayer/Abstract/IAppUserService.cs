using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.BusinessLayer.Abstract
{
    public interface IAppUserService: IGenericService<AppUser>
    {
    }
}
