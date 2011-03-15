using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Row
    {
        private int id;
        private int rowNo;
        private List<int> seats;
        private Cinema c;
        public Row()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int RowNo
        {
            get { return rowNo; }
            set { rowNo = value; }
        }

        public List<int> Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public Cinema C
        {
            get { return c; }
            set { c = value; }
        }
    }
}
