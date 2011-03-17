using System.Collections.Generic;
using TemaXP_DM71_Group1.DBLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.ControllerLayer
{
    class CtrMovie
    {
        public Movie FindMovieByTitle(string title) 
        {
            IFDBMovie DBMovie = new DBMovie();
            return DBMovie.FindMovieByTitle(title, false);
        }

//        public Movie FindMovieById(int id)
//        {
//            IFDBMovie DBMovie = new DBMovie();
//            return DBMovie.FindMovieById(id); 
//        }

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
            Movie mObj = FindMovieByTitle(currentTitle);
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

        public IList<Movie> FindAllMovies()
        {
            IFDBMovie dbMovie = new DBMovie();
            IList<Movie> movieList = dbMovie.FindAllMovies(false);
            return movieList;
        }

      

    }
}
