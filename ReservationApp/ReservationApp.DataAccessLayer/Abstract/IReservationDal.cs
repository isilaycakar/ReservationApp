﻿using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Abstract
{
    public interface IReservationDal: IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int Id);
        List<Reservation> GetListWithReservationByAccepted(int Id);
        List<Reservation> GetListWithReservationByPrevious(int Id);
    }
}
