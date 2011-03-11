using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public interface IFdbShow
    {
        void InsertShow(string movieStartTime, string showDate, Movie movie);

        void DeleteShow(int id);

        void UpdateShow(int id, string movieStartTime, string showDate, Movie movie);

        Show FindShowById(int id);

        //IList<Show> SortShowByDate();

        IList<Show> FindAllShows();

        IList<Show> GetAllShowsOneWeekAhead();
    }

}
