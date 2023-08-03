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
    public class AboutManager : IAboutService
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            aboutDal.Create(t);
        }

        public void TDelete(About t)
        {
            aboutDal.Delete(t);
        }

        public List<About> TGetAll()
        {
            return aboutDal.GetAll();
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            aboutDal.Update(t);
        }
    }
}
