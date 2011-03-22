using System.Collections.Generic;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Booking
    {
        public int Id { get; set; }

        public Show Show { get; set; }

        public IList<Row> Rows { get; set; }

        public IList<Seat> Seats { get; set; }

        public Customer Customer { get; set; }

        public Employee Employee { get; set; }
    }
}