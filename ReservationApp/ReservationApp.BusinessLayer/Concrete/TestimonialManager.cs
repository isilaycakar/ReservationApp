using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;

namespace ReservationApp.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            testimonialDal.Create(t);
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.Delete(t);
        }

        public List<Testimonial> TGetAll()
        {
            return testimonialDal.GetAll();
        }

        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.Update(t);
        }
    }
}
