using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.DataAccessLayer.Repository;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.DataAccessLayer.Entity_Framework
{
    public class EFFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
    }
}
