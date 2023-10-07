namespace ReservationApp.Panel.UI.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIDQuery
    {
        public GetDestinationByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
