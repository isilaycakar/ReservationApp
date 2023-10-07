namespace ReservationApp.Panel.UI.CQRS.Comments.DestinationComments
{
    public class CreateDestinationCommand
    {
        public string? City { get; set; }
        public string? PeriodOfStay { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
