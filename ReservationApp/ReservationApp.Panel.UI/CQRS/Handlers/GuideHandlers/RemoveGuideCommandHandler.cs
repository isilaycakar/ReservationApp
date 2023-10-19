using DocumentFormat.OpenXml.InkML;
using MediatR;
using NuGet.Protocol.Plugins;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.EntityLayer.Concrete;
using ReservationApp.Panel.UI.CQRS.Comments.GuideComments;

namespace ReservationApp.Panel.UI.CQRS.Handlers.GuideHandlers
{
    public class RemoveGuideCommandHandler : IRequestHandler<RemoveGuideComment>
    {
        private readonly DataAccessLayer.Concrete.Context _context;

        public RemoveGuideCommandHandler(DataAccessLayer.Concrete.Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveGuideComment request, CancellationToken cancellationToken)
        {
            var guideComment = await _context.Guides.FindAsync(request.GuideID);
            if (guideComment != null)
            {
                _context.Guides.Remove(guideComment);
                await _context.SaveChangesAsync();
            }

            return Unit.Value;
        }
    }
}
