using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        void TChangeToTrueByGuide(int id);
        void TChangeToFalseByGuide(int id);
    }
}
