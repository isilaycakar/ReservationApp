using MediatR;

namespace ReservationApp.Panel.UI.CQRS.Comments.GuideComments
{
    public class CreateGuideComment: IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
