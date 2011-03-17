﻿using System;
using System.Collections.Generic;
using TemaXP_DM71_Group1_ServiceLib.ModelLayer;

namespace TemaXP_DM71_Group1_ServiceLib.DBLayer
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
