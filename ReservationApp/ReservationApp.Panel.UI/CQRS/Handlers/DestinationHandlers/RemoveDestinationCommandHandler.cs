using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Comments.DestinationComments;

namespace ReservationApp.Panel.UI.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context context;

        public RemoveDestinationCommandHandler(Context context)
        {
            this.context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = context.Destinations.Find(command.Id);
            if (values != null)
            {
                context.Destinations.Remove(values);
                context.SaveChanges();
            }
        }
    }
}
