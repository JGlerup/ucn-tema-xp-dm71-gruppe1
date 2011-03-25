using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_WCFServiceLib.ControllerLayer;
using TemaXP_WCFServiceLib.ModelLayer;

namespace TemaXP_WCFServiceLib
{
    public class Service1 : IService1
    {
        private CtrCinema ctrCinema;
        private CtrMovie ctrMovie;
        private CtrShow ctrShow;

        public Service1()
        {
            this.ctrCinema = new CtrCinema();
            this.ctrMovie = new CtrMovie();
            this.ctrShow = new CtrShow();
        }

//        CtrCinema
        public Cinema FindCinemaByName(string cinemaName, bool retrieveAssociation)
        {
            return ctrCinema.FindCinemaByName(cinemaName, retrieveAssociation);
        }

        public IList<Cinema> FindAllCinemas(bool retrieveAssociation)
        {
            return ctrCinema.FindAllCinemas(retrieveAssociation);
        }

        public void InsertCinema(string cinemaName, int noOfRows)
        {
            ctrCinema.InsertCinema(cinemaName, noOfRows);
        }

        public void AddSeatsToRow(Cinema c, int rowNumber, int noOfSeats)
        {
            ctrCinema.AddSeatsToRow(c, rowNumber, noOfSeats);
        }

        public void UpdateCinema(Cinema c, string cinemaName)
        {
            ctrCinema.UpdateCinema(c,cinemaName);
        }

        public void DeleteCinema(Cinema c)
        {
            ctrCinema.DeleteCinema(c);
        }

//        CtrMovie
        public Movie FindMovieByTitle(string title, bool retrieveAssociation)
        {
            return ctrMovie.FindMovieByTitle(title, retrieveAssociation);
        }

        public Movie FindMovieById(Movie m, bool retrieveAssociation)
        {
            return ctrMovie.FindMovieById(m, retrieveAssociation);
        }

        public void InsertMovie(string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            ctrMovie.InsertMovie(releaseDate, title, distributor, arrivalDate, returnDate, duration, director, actors, movieDescription);
        }

        public void UpdateMovie(string currentTitle, string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            ctrMovie.UpdateMovie(currentTitle, releaseDate, title, distributor,arrivalDate, returnDate, duration, director, actors, movieDescription);
        }

        public void DeleteMovie(Movie m)
        {
            ctrMovie.DeleteMovie(m);
        }

        public IList<Movie> FindAllMovies(bool retrieveAssociation)
        {
            return ctrMovie.FindAllMovies(retrieveAssociation);
        }

//        CtrShow
        public void InsertShow(string movieStartTime, string showDate, Movie movie)
        {
            ctrShow.InsertShow(movieStartTime, showDate, movie);
        }

        public void DeleteShow(Show s)
        {
            ctrShow.DeleteShow(s);
        }

        public void UpdateShow(Show s, string movieStartTime, string showDate, Movie movie)
        {
            ctrShow.UpdateShow(s, movieStartTime, showDate, movie);
        }

        public IList<Show> FindAllShows(bool retrieveAssociation)
        {
            return ctrShow.FindAllShows(retrieveAssociation);
        }

        public Show FindShowByMovieId(Movie m, bool retrieveAssociation)
        {
            return ctrShow.FindShowByMovieId(m, retrieveAssociation);
        }

        public Show FindShowByMovieIdAndShowDate(Movie m, string date)
        {
            return ctrShow.FindShowByMovieIdAndShowDate(m, date);
        }

        public IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation)
        {
            return ctrShow.GetAllShowsOneWeekAhead(retrieveAssociation);
        }
    }
}
