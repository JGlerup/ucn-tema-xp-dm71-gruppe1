using System;
using System.Collections.Generic;

namespace TemaXP_DM71_Group1_ServiceLib.ModelLayer
{
    public class Cinema
    {
        private int ID;
        private String cinemaName;
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
            get { return cinemaName; }
            set { cinemaName = value; }
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

        public IList<Row> FillRows()
        {
            IList<Row> list = new List<Row>();
            int i = 1;
            while (i <= noOfRows)
            {
                Row r = new Row();
                r.RowNo = i;
                i++;
            }
            return list;
        }

        public override string ToString()
        {
            return cinemaName;
        }
    }
}
