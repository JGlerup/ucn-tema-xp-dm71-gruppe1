using System;
using System.Collections.Generic;
using TemaXP_WCFServiceLib.ModelLayer;

namespace TemaXP_WCFServiceLib.DBLayer
{
    public interface IFDBMovie
    {
        void InsertMovie(Movie m);

        void DeleteMovie(Movie m);

        void UpdateMovie(Movie m);

        Movie FindMovieByTitle(String title, bool retrieveAssociation);

        Movie FindMovieById(Movie m, bool retrieveAssociation);

        IList<Movie> FindAllMovies(bool retrieveAssociation);
    }
}
