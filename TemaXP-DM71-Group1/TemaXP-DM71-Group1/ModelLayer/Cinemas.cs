using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Cinemas
    {
        private String name;
        private int nrOfSeats;
        //private IList<Seats> seats;

        public Cinemas()
        {

        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NrOfSeats
        {
            get { return nrOfSeats; }
            set { nrOfSeats = value; }
        }
    }
}
