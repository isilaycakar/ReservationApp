using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class NewsLatterManager : INewsLatterService
    {
        INewsLatterDal newsLatterDal;

        public NewsLatterManager(INewsLatterDal newsLatterDal)
        {
            this.newsLatterDal = newsLatterDal;
        }

        public void TAdd(NewsLatter t)
        {
            newsLatterDal.Create(t);
        }

        public void TDelete(NewsLatter t)
        {
            newsLatterDal.Delete(t);
        }

        public List<NewsLatter> TGetAll()
        {
            return newsLatterDal.GetAll();
        }

        public NewsLatter TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLatter t)
        {
            newsLatterDal.Update(t);
        }
    }
    {
    }
}
