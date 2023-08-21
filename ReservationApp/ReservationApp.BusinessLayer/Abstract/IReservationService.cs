using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int Id);
        List<Reservation> GetListWithReservationByAccepted(int Id);
        List<Reservation> GetListWithReservationByPrevious(int Id);
    }

}
