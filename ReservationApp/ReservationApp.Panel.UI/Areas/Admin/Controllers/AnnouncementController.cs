using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.EntityLayer.Concrete;
using ReservationApp.Panel.UI.Areas.Admin.Models;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService announcementService;
        private readonly IMapper mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            this.announcementService = announcementService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            //List<Announcement> announcements = announcementService.TGetAll();
            //List<AnnouncementListModel> model = new List<AnnouncementListModel>();
            //foreach (var item in announcements)
            //{
            //    AnnouncementListModel announcementListModel = new AnnouncementListModel();
            //    announcementListModel.ID = item.AnnouncementID;
            //    announcementListModel.Title = item.Title;
            //    announcementListModel.Content = item.Content;

            //    model.Add(announcementListModel);
            //}
            //return View(model);

            var values = mapper.Map<List<AnnouncementListDTO>>(announcementService.TGetAll());
            return View(values);
        }

        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Route("{id}")]
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = announcementService.TGetByID(id);
            announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [Route("{id}")]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = mapper.Map<AnnouncementUpdateDTO>(announcementService.TGetByID(id));
            return View(values);
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                announcementService.TUpdate(new Announcement()
                {
                    AnnouncementID =  model.AnnouncementID,
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
