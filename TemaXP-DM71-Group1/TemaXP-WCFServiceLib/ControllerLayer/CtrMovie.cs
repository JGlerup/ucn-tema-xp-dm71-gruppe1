﻿using System.Collections.Generic;
using TemaXP_WCFServiceLib.DBLayer;
using TemaXP_WCFServiceLib.ModelLayer;

namespace TemaXP_WCFServiceLib.ControllerLayer
{
    public class CtrMovie
    {
        public Movie FindMovieByTitle(string title, bool retrieveAssociation)
        {
            IFDBMovie dbMovie = new DBMovie();
            return dbMovie.FindMovieByTitle(title, retrieveAssociation);
        }

        public Movie FindMovieById(Movie m, bool retrieveAssociation)
        {
            IFDBMovie DBMovie = new DBMovie();
            return DBMovie.FindMovieById(m, retrieveAssociation);
        }

        public void InsertMovie(string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            IFDBMovie DBMovie = new DBMovie();
            Movie mObj = new Movie();
            mObj.ReleaseDate = releaseDate;
            mObj.Title = title;
            mObj.Distributor = distributor;
            mObj.ArrivalDate = arrivalDate;
            mObj.ReturnDate = returnDate;
            mObj.Duration = duration;
            mObj.Director = director;
            mObj.Actors = actors;
            mObj.MovieDescription = movieDescription;
            DBMovie.InsertMovie(mObj);
        }

        public void UpdateMovie(string currentTitle, string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            IFDBMovie DBMovie = new DBMovie();
            Movie mObj = FindMovieByTitle(currentTitle, false);
            mObj.ReleaseDate = releaseDate;
            mObj.Title = title;
            mObj.Distributor = distributor;
            mObj.ArrivalDate = arrivalDate;
            mObj.ReturnDate = returnDate;
            mObj.Duration = duration;
            mObj.Director = director;
            mObj.Actors = actors;
            mObj.MovieDescription = movieDescription;
            DBMovie.UpdateMovie(mObj);

        }

        public void DeleteMovie(Movie m)
        {
            IFDBMovie DBMovie = new DBMovie();
            DBMovie.DeleteMovie(m);

        }

        public IList<Movie> FindAllMovies(bool retrieveAssociation)
        {
            IFDBMovie dbMovie = new DBMovie();
            IList<Movie> movieList = dbMovie.FindAllMovies(retrieveAssociation);
            return movieList;
        }

      

    }
}
