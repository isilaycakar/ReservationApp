using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
