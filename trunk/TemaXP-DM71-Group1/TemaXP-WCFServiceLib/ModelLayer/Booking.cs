using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_WCFServiceLib.ModelLayer
{
    class Booking
    {
        public int Id { get; set; }

        public Show Show { get; set; }

        public IList<Row> Rows { get; set; }

        public IList<Seat> Seats { get; set; }

        public Customer Customer { get; set; }

        public Employee Employee { get; set; }
    }
}
