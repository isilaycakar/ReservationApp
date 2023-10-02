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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            this.announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
            announcementDal.Create(t);
        }

        public void TDelete(Announcement t)
        {
            announcementDal.Delete(t);
        }

        public List<Announcement> TGetAll()
        {
            return announcementDal.GetAll();
        }

        public Announcement TGetByID(int id)
        {
            return announcementDal.GetByID(id);
        }

        public void TUpdate(Announcement t)
        {
            announcementDal.Update(t);
        }
    }
}
