﻿using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using ReservationApp.BusinessLayer.Abstract;
using ReservationApp.DataAccessLayer.Concrete;
using ReservationApp.Panel.UI.Models;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExcelController : Controller
    {
        private readonly IExcelService excelService;

        public ExcelController(IExcelService excelService)
        {
            this.excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModel = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModel = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    PeriodOfStay = x.PeriodOfStay,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModel;
        }

        public IActionResult StaticExcelReport()
        {
            return File(excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniExcel.xlsx");
        }
        public IActionResult DestinationExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.PeriodOfStay;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadshtml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }
}
