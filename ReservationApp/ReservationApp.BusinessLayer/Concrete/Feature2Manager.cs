using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class Feature2Manager : IFeature2Service
    {
        IFeature2Dal feature2Dal;

        public Feature2Manager(IFeature2Dal feature2Dal)
        {
            this.feature2Dal = feature2Dal;
        }

        public void TAdd(Feature2 t)
        {
            feature2Dal.Create(t);
        }

        public void TDelete(Feature2 t)
        {
            feature2Dal.Delete(t);
        }

        public List<Feature2> TGetAll()
        {
            return feature2Dal.GetAll();
        }

        public Feature2 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature2 t)
        {
            feature2Dal.Update(t);
        }
    }
}
