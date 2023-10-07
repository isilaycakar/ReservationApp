using DocumentFormat.OpenXml.Wordprocessing;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Comments.DestinationComments;

namespace ReservationApp.Panel.UI.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context context;

        public CreateDestinationCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(CreateDestinationCommand command)
        {
            context.Destinations.Add(new EntityLayer.Concrete.Destination
            {
                City = command.City,
                PeriodOfStay = command.PeriodOfStay,
                Price = command.Price,
                Capacity = command.Capacity,
                Status = true
            });
            context.SaveChanges();
        }
    }
}
