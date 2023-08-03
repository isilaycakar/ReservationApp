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
    public class ContactManager: IContactService
    {
        IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            contactDal.Create(t);
        }

        public void TDelete(Contact t)
        {
            contactDal.Delete(t);
        }

        public List<Contact> TGetAll()
        {
            return contactDal.GetAll();
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            contactDal.Update(t);
        }
    }
}
}
