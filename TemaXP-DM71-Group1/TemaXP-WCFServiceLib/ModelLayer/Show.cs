﻿using System.Collections.Generic;

namespace TemaXP_WCFServiceLib.ModelLayer
{
    public class Show
    {
        private int _id;
        private string _movieStartTime;
        private string _showDate;
        private Movie _movie;
        private IList<Cinema> cinemas;
        private IList<Booking> bookings;

        public Show(int id, string movieStartTime, string showDate, Movie movie)
        {
            Id = id;
            MovieStartTime = movieStartTime;
            Movie = movie;
            ShowDate = showDate;
        }

        public Show()
        {
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string MovieStartTime
        {
            get { return _movieStartTime; }
            set { _movieStartTime = value; }
        }

        public string ShowDate
        {
            get { return _showDate; }
            set { _showDate = value; }
        }

        public Movie Movie
        {
            get { return _movie; }
            set { _movie = value; }
        }

        public IList<Cinema> Cinemas
        {
            get { return cinemas; }
            set { cinemas = value; }
        }

        public IList<Booking> Bookings
        {
            get { return bookings; }
            set { bookings = value; }
        }

        public override string ToString()
        {
            return "Dato: " + ShowDate + " " + "Starttidspunkt: " + MovieStartTime + " " + Movie;
        }
    }
}