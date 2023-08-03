using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            this.guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            guideDal.Create(t);
        }

        public void TDelete(Guide t)
        {
            guideDal.Delete(t);
        }

        public List<Guide> TGetAll()
        {
            return guideDal.GetAll();
        }

        public Guide TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guide t)
        {
            guideDal.Update(t);
        }
    }
    {
    }
}
