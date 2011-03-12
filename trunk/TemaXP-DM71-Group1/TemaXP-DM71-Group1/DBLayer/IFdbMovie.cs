using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public interface IFDBMovie
    {
        void InsertMovie(Movie m);

        void DeleteMovie(String title);

        void UpdateMovie(Movie m);

        Movie FindMovieByTitle(String title);

        Movie FindMovieById(int id);

        IList<Movie> FindAllMovies();
    }
}
