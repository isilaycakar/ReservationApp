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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListWithReservationByAccepted(int Id)
        {
           return _reservationDal.GetListWithReservationByAccepted(Id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int Id)
        {
            return _reservationDal.GetListWithReservationByPrevious(Id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int Id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(Id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Create(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
