using Microsoft.EntityFrameworkCore;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Queries.DestinationQueries;
using ReservationApp.Panel.UI.CQRS.Results.DestinationResults;

namespace ReservationApp.Panel.UI.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context context;

        public GetAllDestinationQueryHandler(Context context)
        {
            this.context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                ID = x.DestinationID,
                Capacity = x.Capacity,
                City = x.City,
                PeriodOfStay = x.PeriodOfStay,
                Price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
