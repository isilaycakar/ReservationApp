using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Queries.DestinationQueries;
using ReservationApp.Panel.UI.CQRS.Results.DestinationResults;

namespace ReservationApp.Panel.UI.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handler(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIDQueryResult
            {
                ID = values.DestinationID,
                City = values.City,
                PeriodOfStay = values.PeriodOfStay,
                Price = values.Price
            };
        }
    }
}
