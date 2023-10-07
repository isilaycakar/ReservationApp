namespace ReservationApp.Panel.UI.CQRS.Results.DestinationResults
{
    public class GetDestinationByIDQueryResult
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string PeriodOfStay { get; set; }
        public double Price { get; set; }
    }
}
