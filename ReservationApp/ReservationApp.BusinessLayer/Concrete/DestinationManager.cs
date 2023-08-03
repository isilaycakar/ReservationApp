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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            this.destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            destinationDal.Create(t);
        }

        public void TDelete(Destination t)
        {
            destinationDal.Delete(t);
        }

        public List<Destination> TGetAll()
        {
            return destinationDal.GetAll();
        }

        public Destination TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination t)
        {
            destinationDal.Update(t);
        }
    }
}
