using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationApp.Panel.UI.Areas.Admin.Models;
using System.Net.Http.Headers;

namespace ReservationApp.Panel.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BookingHotelSearchController : Controller
    {
        [Route("{Id}")]
        public async Task<IActionResult> Index(int Id)
        {
            int? cityId = TempData["CityId"] as int?;

            string cityName = TempData["CityName"] as string;
            string countryName = TempData["CountryName"] as string;

            ViewBag.CityName = cityName;
            ViewBag.CountryName = countryName;

            if (cityId == null)
            {
                ViewBag.ErrorMessage = "Şehir ID'si bulunamadı.";
                return View();
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://tripadvisor16.p.rapidapi.com/api/v1/hotels/searchHotels?geoId={cityId}&checkIn=2023-10-08&checkOut=2023-10-10&pageNumber=1&adults=2&rooms=1&currencyCode=USD"),
                Headers =
    {
        { "X-RapidAPI-Key", "09b409a634mshe33d26ebc216781p112b0fjsn5b1e8bb3f8e5" },
        { "X-RapidAPI-Host", "tripadvisor16.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonSerializerSettings = new JsonSerializerSettings
                {
                    Error = (sender, args) =>
                    {
                        args.ErrorContext.Handled = true; // Hataları yoksay
                    }
                };
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);

                return View(values.data.data);
            }
        }

        public IActionResult GetCityDestID()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCityDestID(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://tripadvisor16.p.rapidapi.com/api/v1/hotels/searchLocation?query={p}"),
                Headers =
    {
        { "X-RapidAPI-Key", "09b409a634mshe33d26ebc216781p112b0fjsn5b1e8bb3f8e5" },
        { "X-RapidAPI-Host", "tripadvisor16.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var cityData = JsonConvert.DeserializeObject<BookingSearchCityViewModel>(body);

                // Şehir ID'sini alın
                int? cityId = cityData.data.FirstOrDefault()?.geoId;
                if (cityId != null)
                {
                    TempData["CityId"] = cityId;
                    TempData["CityName"] = cityData.data.FirstOrDefault()?.title;
                    TempData["CountryName"] = cityData.data.FirstOrDefault()?.secondaryText;

                    return RedirectToAction("Index", new {Id = cityId});
                }
                else
                {
                    ViewBag.ErrorMessage = "Şehir ID'si bulunamadı.";
                    return View();
                }
            }
        }
    }
}
