using MediatR;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Comments.GuideComments;

namespace ReservationApp.Panel.UI.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommentHandler : IRequestHandler<CreateGuideComment>
    {
        private readonly Context _context;

        public CreateGuideCommentHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideComment request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new EntityLayer.Concrete.Guide
            {
                Description = request.Description,
                Name = request.Name,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
