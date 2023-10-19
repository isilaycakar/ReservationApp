using MediatR;
using ReservationApp.Panel.UI.CQRS.Results.GuideResults;

namespace ReservationApp.Panel.UI.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery: IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
