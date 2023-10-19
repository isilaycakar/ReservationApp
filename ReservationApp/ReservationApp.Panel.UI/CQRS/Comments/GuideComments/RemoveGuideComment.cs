using MediatR;

namespace ReservationApp.Panel.UI.CQRS.Comments.GuideComments
{
    public class RemoveGuideComment : IRequest
    {
        public int GuideID { get; set; }

        public RemoveGuideComment(int guideID)
        {
            GuideID = guideID;
        }
    }
}
