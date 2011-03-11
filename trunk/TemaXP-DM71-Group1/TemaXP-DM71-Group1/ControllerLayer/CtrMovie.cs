using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;
using TemaXP_DM71_Group1.ControllerLayer;
using TemaXP_DM71_Group1.DBLayer;


namespace TemaXP_DM71_Group1.ControllerLayer
{
    class CtrMovie
    {
        public Movie FindMovie(string title)
        {
            IFdbMovie dbMovie = new DbMovie();
            return dbMovie.FindMovie(title);
        }
        public void InsertMovie(string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            IFdbMovie dbMovie = new DbMovie();
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
            dbMovie.InsertMovie(mObj);
        }
        public void UpdateMovie(string currentTitle, string releaseDate, string title, string distributor, string arrivalDate, string returnDate, string duration, string director, string actors, string movieDescription)
        {
            IFdbMovie dbMovie = new DbMovie();
            Movie mObj = FindMovie(currentTitle);
            mObj.ReleaseDate = releaseDate;
            mObj.Title = title;
            mObj.Distributor = distributor;
            mObj.ArrivalDate = arrivalDate;
            mObj.ReturnDate = returnDate;
            mObj.Duration = duration;
            mObj.Director = director;
            mObj.Actors = actors;
            mObj.MovieDescription = movieDescription;
            dbMovie.UpdateMovie(mObj);

        }
        public void DeleteMovie(string title)
        {
            IFdbMovie dbMovie = new DbMovie();
            dbMovie.DeleteMovie(title);

        }

        public IList<Movie> FindAllMovies()
        {
            IFdbMovie dbMovie = new DbMovie();
            return dbMovie.FindAllMovies();
        }

      

    }
}
