using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationApp.Panel.UI.CQRS.Comments.DestinationComments
{
    public class UpdateDestinationCommand
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string PeriodOfStay { get; set; }
        public double Price { get; set; }
    }
}
