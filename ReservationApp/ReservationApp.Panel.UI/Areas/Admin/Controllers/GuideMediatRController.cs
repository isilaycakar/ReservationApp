using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.Panel.UI.CQRS.Comments.GuideComments;
using ReservationApp.Panel.UI.CQRS.Queries.GuideQueries;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetGuides(int Id)
        {
            var values = await _mediator.Send(new GetGuideByIDQuery(Id));
            return View(values);
        }

        [HttpPost("{Id}")]
        public async Task<IActionResult> GetGuides(UpdateGuideComment comment, int Id)
        {
            if (Id == comment.GuideID)
            {
                await _mediator.Send(comment);
                return RedirectToAction("Index");
            }
            return View();
            
        }

        public IActionResult AddGuide()
        {
            return View();
        }
                
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideComment comment)
        {
            await _mediator.Send(comment);
            return RedirectToAction("Index");
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> RemoveGuide(int Id)
        {
            var comment = new RemoveGuideComment(Id);
            await _mediator.Send(comment);
            return RedirectToAction("Index");
        }
    }
}
