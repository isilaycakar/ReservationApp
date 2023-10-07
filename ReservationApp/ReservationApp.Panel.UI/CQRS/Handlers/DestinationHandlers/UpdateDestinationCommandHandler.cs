using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Comments.DestinationComments;

namespace ReservationApp.Panel.UI.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.ID);
            values.City = command.City;
            values.PeriodOfStay = command.PeriodOfStay;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
