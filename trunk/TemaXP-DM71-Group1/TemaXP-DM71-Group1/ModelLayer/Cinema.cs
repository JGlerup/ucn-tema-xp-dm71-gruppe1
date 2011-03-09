using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Cinema
    {
        private int noOfCinema;
        private int noOfSeats;
        //private IList<Seats> seats;

        public Cinema(int noOfCinema, int noOfSeats)
        {
            this.noOfCinema = noOfCinema;
            this.noOfSeats = noOfSeats;
        }

        public Cinema()
        {

        }


        public int NoOfCinema
        {
            get { return noOfCinema; }
            set { noOfCinema = value; }
        }

        public int NoOfSeats
        {
            get { return noOfSeats; }
            set { noOfSeats = value; }
        }
    }
}
