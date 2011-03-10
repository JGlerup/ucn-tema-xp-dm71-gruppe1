using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public interface IFdbShow
    {
        void InsertShow(Show m);

        void DeleteShow(Show m);

        void UpdateShow(Show m);

        Show FindShowById(String title);

        IList<Show> SortShowByDate();

        IList<Show> GetAllShows();
    }

}
