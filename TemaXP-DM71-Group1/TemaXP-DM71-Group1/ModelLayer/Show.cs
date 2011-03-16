using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{
    public class Show
    {
        private int _id;
        private string _movieStartTime;
        private string _showDate;
        private Movie _movie;

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

        public override string ToString()
        {
            return "Dato: " + ShowDate + " " + "Starttidspunkt: " + MovieStartTime + " " + Movie;
        }
    }
}