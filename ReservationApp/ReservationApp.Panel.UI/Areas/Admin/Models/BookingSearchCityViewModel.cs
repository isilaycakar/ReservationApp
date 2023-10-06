namespace ReservationApp.Panel.UI.Areas.Admin.Models
{
    public class BookingSearchCityViewModel
    {

            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Datum[] data { get; set; }

        public class Datum
        {
            public string title { get; set; }
            public int geoId { get; set; }
            public string documentId { get; set; }
            public string trackingItems { get; set; }
            public string secondaryText { get; set; }
        }

    }
}
