using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public interface IFDBShow
    {
        void InsertShow(Show s);

        void DeleteShow(Show s);

        void UpdateShow(Show s);

        Show FindShowByMovieIdAndShowDate(Movie m, string date, bool retrieveAssociation);

        Show FindShowByMovieId(Movie m, bool retrieveAssociation);

        Show FindShowByCinemaID(Cinema c, bool retrieveAssociation);

        //IList<Show> SortShowByDate();

        IList<Show> FindAllShows(bool retrieveAssociation);

        IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation);
    }

}
