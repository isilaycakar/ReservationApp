using MediatR;
using NuGet.Protocol.Plugins;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Comments.GuideComments;

namespace ReservationApp.Panel.UI.CQRS.Handlers.GuideHandlers
{
    public class UpdateGuideCommentHandler : IRequestHandler<UpdateGuideComment>
    {
        private readonly Context _context;

        public UpdateGuideCommentHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateGuideComment request, CancellationToken cancellationToken)
        {
            _context.Guides.Update(new EntityLayer.Concrete.Guide
            {
                Description = request.Description,
                Name = request.Name
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
