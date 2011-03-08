using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemaXP_DM71_Group1.ModelLayer
{

    public class Movie
    {   
        private string releaseDate;
        private string title;
        private string distributor;
        private string arrivalDate;
        private string returnDate;
        private string duration;
        private string director;
        private string actors;
        private string movieDescription;

        public Movie(string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            this.releaseDate = releaseDate;
            this.title = title;
            this.distributor = distributor;
            this.arrivalDate = arrivalDate;
            this.returnDate = returnDate;
            this.duration = duration;
            this.director = director;
            this.actors = actors;
            this.movieDescription = movieDescription;
        }

        public Movie()
        {

        }

        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Distributor
        {
            get { return distributor; }
            set { distributor = value; }
        }

        public string ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public string Actors
        {
            get { return actors; }
            set { actors = value; }
        }

        public string MovieDescription
        {
            get { return movieDescription; }
            set { movieDescription = value; }
        }
    }
}
