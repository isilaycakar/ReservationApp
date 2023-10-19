using MediatR;
using NuGet.Protocol.Plugins;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Queries.GuideQueries;
using ReservationApp.Panel.UI.CQRS.Results.GuideResults;

namespace ReservationApp.Panel.UI.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.GuideID);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
