﻿using System.Collections.Generic;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Row
    {
        private int id;
        private int rowNo;
        private List<int> seats;
        private int noOfSeats;
        private Cinema cinema;
        private Booking booking;

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

        public int NoOfSeats
        {
            get { return noOfSeats; }
            set { noOfSeats = value; }
        }

        public Cinema Cinema
        {
            get { return cinema; }
            set { cinema = value; }
        }

        public Booking Booking
        {
            get { return booking; }
            set { booking = value; }
        }

        public override string ToString()
        {
            return RowNo.ToString();
        }
    }
}
