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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            this.contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs t)
        {
            contactUsDal.Create(t);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            contactUsDal.Delete(t);
        }

        public List<ContactUs> TGetAll()
        {
            return contactUsDal.GetAll();
        }

        public ContactUs TGetByID(int id)
        {
            return contactUsDal.GetByID(id);
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return contactUsDal.GetListContactUsByTrue();
        }

        public void TUpdate(ContactUs t)
        {
            contactUsDal.Update(t);
        }
    }
}
