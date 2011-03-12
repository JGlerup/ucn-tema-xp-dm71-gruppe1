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

        void DeleteShow(int id);

        void UpdateShow(Show s);

        Show FindShowById(int id);

        //IList<Show> SortShowByDate();

        IList<Show> FindAllShows();

        IList<Show> GetAllShowsOneWeekAhead();
    }

}
