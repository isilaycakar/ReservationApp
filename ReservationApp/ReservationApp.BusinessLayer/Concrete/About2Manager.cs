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
    public class About2Manager : IAbout2Service
    {
        IAbout2Dal about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            this.about2Dal = about2Dal;
        }

        public void TAdd(About2 t)
        {
            about2Dal.Create(t);
        }

        public void TDelete(About2 t)
        {
            about2Dal.Delete(t);
        }

        public List<About2> TGetAll()
        {
            return about2Dal.GetAll();
        }

        public About2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About2 t)
        {
            about2Dal.Update(t);
        }

    }
}
