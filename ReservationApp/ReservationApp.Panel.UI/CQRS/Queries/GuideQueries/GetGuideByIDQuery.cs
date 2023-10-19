using MediatR;
using ReservationApp.Panel.UI.CQRS.Results.GuideResults;

namespace ReservationApp.Panel.UI.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery: IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int guideID)
        {
            GuideID = guideID;
        }

        public int GuideID { get; set; }
    }
}
