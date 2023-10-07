using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.Panel.UI.CQRS.Comments.DestinationComments;
using ReservationApp.Panel.UI.CQRS.Handlers.DestinationHandlers;
using ReservationApp.Panel.UI.CQRS.Queries.DestinationQueries;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [AllowAnonymous]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler getAllDestinationQueryHandler;
        private readonly GetDestinationByIDQueryHandler getDestinationByIDQueryHandler;
        private readonly CreateDestinationCommandHandler createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler updateDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetDestinationByIDQueryHandler getDestinationByIDQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            this.getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            this.getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
            this.createDestinationCommandHandler = createDestinationCommandHandler;
            this.removeDestinationCommandHandler = removeDestinationCommandHandler;
            this.updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetDestination(int Id)
        {
            var values = getDestinationByIDQueryHandler.Handler(new GetDestinationByIDQuery(Id));
            return View(values);
        }

        [HttpPost]
        public IActionResult EditDestination(UpdateDestinationCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            try
            {
                updateDestinationCommandHandler.Handle(command);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Log the exception and return an error view.
                // You can also add a custom error message to the ViewBag.
                ViewBag.ErrorMessage = "An error occurred while updating the destination.";
                return View(command);
            }
        }

        public IActionResult AddDestination()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [Route("{Id}")]
        public IActionResult DeleteDestination(int Id)
        {
            removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(Id));
            return RedirectToAction("Index");

        }
    }
}
