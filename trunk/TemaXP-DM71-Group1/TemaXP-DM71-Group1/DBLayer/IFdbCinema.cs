using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    interface IFdbCinema
    {
        void InsertCinema(Cinema c);

        void DeleteCinema(Cinema c);

        void UpdateCinema(Cinema c);

        Cinema FindCinemaByNoOfCinema(int noOfCinema, bool retrieveAssociation);

        Cinema FindCinemaByShowID(Show s, bool retrieveAssociation);

        IList<Cinema> FindAllShows(bool retrieveAssociation);
    }
}
