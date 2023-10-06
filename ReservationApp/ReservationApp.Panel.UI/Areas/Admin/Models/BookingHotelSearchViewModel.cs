namespace ReservationApp.Panel.UI.Areas.Admin.Models
{
    public class BookingHotelSearchViewModel
    {

            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Data data { get; set; }

        public class Data
        {
            public string sortDisclaimer { get; set; }
            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public string id { get; set; }
            public string title { get; set; }
            public string primaryInfo { get; set; }
            public string secondaryInfo { get; set; }
            public Badge badge { get; set; }
            public Bubblerating bubbleRating { get; set; }
            public bool isSponsored { get; set; }
            public string accentedLabel { get; set; }
            public string provider { get; set; }
            public string priceForDisplay { get; set; }
            public object strikethroughPrice { get; set; }
            public string priceDetails { get; set; }
            public object priceSummary { get; set; }
            public Cardphoto[] cardPhotos { get; set; }
            public Commerceinfo commerceInfo { get; set; }
        }

        public class Badge
        {
            public string size { get; set; }
            public string type { get; set; }
            public string year { get; set; }
        }

        public class Bubblerating
        {
            public string count { get; set; }
            public float rating { get; set; }
        }

        public class Commerceinfo
        {
            public string externalUrl { get; set; }
            public string provider { get; set; }
            public Loadingmessage loadingMessage { get; set; }
            public Pricefordisplay priceForDisplay { get; set; }
            public object strikethroughPrice { get; set; }
            public object pricingPeriod { get; set; }
            public Details details { get; set; }
            public object commerceSummary { get; set; }
            public object roomUrgencyMessage { get; set; }
            public object[] labels { get; set; }
        }

        public class Loadingmessage
        {
            public string text { get; set; }
        }

        public class Pricefordisplay
        {
            public string text { get; set; }
            public object debugValueKey { get; set; }
        }

        public class Details
        {
            public string text { get; set; }
        }

        public class Cardphoto
        {
            public string __typename { get; set; }
            public Sizes sizes { get; set; }
        }

        public class Sizes
        {
            public string __typename { get; set; }
            public int maxHeight { get; set; }
            public int maxWidth { get; set; }
            public string urlTemplate { get; set; }
        }

    }
}
