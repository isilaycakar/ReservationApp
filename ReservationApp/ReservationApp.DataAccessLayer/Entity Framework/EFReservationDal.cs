using Microsoft.EntityFrameworkCore;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        Context context = new Context();
        public List<Reservation> GetListWithReservationByAccepted(int Id)
        {
            return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == Id).ToList();
        }

        public List<Reservation> GetListWithReservationByPrevious(int Id)
        {
            return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == Id).ToList();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int Id)
        {
            return context.Reservations.Include(x=>x.Destination).Where(x=>x.Status == "Onay Bekliyor" && x.AppUserId == Id).ToList();
        }
    }

}
