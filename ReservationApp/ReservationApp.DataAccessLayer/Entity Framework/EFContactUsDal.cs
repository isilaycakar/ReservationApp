using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        Context context = new Context();
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            var values = context.ContactUs.Where(x=>x.MessageStatus == false).ToList();
            return values;
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            var values = context.ContactUs.Where(x => x.MessageStatus == true).ToList();
            return values;
        }
    }
}
