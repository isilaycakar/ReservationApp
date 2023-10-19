using MediatR;

namespace ReservationApp.Panel.UI.CQRS.Comments.GuideComments
{
    public class UpdateGuideComment: IRequest
    {
        public int GuideID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
