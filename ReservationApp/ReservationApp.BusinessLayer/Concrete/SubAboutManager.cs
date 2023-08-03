using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            this.subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout t)
        {
            subAboutDal.Create(t);
        }

        public void TDelete(SubAbout t)
        {
            subAboutDal.Delete(t);
        }

        public List<SubAbout> TGetAll()
        {
            return subAboutDal.GetAll();
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout t)
        {
            subAboutDal.Update(t);
        }
    }
    {
    }
}
