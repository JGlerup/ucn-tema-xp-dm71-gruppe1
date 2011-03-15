using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Cinema
    {
        private int ID;
        private String CinemaName;
        private int noOfSeats;
        private int noOfRows;
        private IList<Row> rows;

        //private IList<Seats> seats;

//        public Cinema(int cinemaName, int noOfSeats)
//        {
//            this.CinemaName = cinemaName;
//            this.noOfSeats = noOfSeats;
//        }

        public Cinema()
        {

        }


        public string CinemaName
        {
            get { return CinemaName; }
            set { CinemaName = value; }
        }

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int NoOfSeats
        {
            get { return noOfSeats; }
            set { noOfSeats = value; }
        }

        public int NoOfRows
        {
            get { return noOfRows; }
            set { noOfRows = value; }
        }

        public IList<Row> Rows
        {
            get { return rows; }
            set { rows = value; }
        }
    }
}
