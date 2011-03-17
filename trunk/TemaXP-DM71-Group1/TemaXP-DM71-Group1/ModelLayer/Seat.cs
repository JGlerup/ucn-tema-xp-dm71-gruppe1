﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Seat
    {
        private int id;
        private int seatNo;
        private Row row;
        private string taken;
        private string reserved;

        public Seat()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int SeatNo
        {
            get { return seatNo; }
            set { seatNo = value; }
        }

        public Row Row
        {
            get { return row; }
            set { row = value; }
        }

        public string Taken
        {
            get { return taken; }
            set { taken = value; }
        }

        public string Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
    }
}