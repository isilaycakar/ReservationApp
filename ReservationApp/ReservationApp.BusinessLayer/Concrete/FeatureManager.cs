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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            this.featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            featureDal.Create(t);
        }

        public void TDelete(Feature t)
        {
            featureDal.Delete(t);
        }

        public List<Feature> TGetAll()
        {
            return featureDal.GetAll();
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
            featureDal.Update(t);
        }
    
    }
}
