using System.Collections.Generic;
using TemaXP_Groupe1_WcfService1.ModelLayer;

namespace TemaXP_Groupe1_WcfService1.DBLayer
{
    public interface IFDBShow
    {
        void InsertShow(Show s);

        void DeleteShow(Show s);

        void UpdateShow(Show s);

        Show FindShowByMovieIdAndShowDate(Movie m, string date, bool retrieveAssociation);

        Show FindShowByMovieId(Movie m, bool retrieveAssociation);

        IList<Show> FindShowsByCinemaId(Cinema c, bool retrieveAssociation);

        IList<Show> FindAllShows(bool retrieveAssociation);

        IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation);

        Show FindShowById(Show s, bool retrieveAssociation);

        void InsertCinemaShow(Cinema c, Show s);

        void DeleteCinemaShow(Cinema c, Show s);

        void UpdateCinemaShow(Cinema oldc, Show olds, Cinema newc, Show news);
    }

}
