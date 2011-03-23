using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_Groupe1_WcfService1.ModelLayer
{
    public class Booking
    {
        public int Id { get; set; }

        public Show Show { get; set; }

        public int NoOfSeats { get; set; }

        public IList<Row> Rows { get; set; }

        public IList<Seat> Seats { get; set; }

        public Customer Customer { get; set; }

        public Employee Employee { get; set; }
    }
}
