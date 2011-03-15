using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public interface IFdbCinema
    {
        void InsertCinema(Cinema c);

        void DeleteCinema(Cinema c);

        void UpdateCinema(Cinema c);

        Cinema FindCinemaByNoOfSeats(int noOfSeats, bool retrieveAssociation);

        IList<Cinema> FindCinemasByShowID(Show s, bool retrieveAssociation);

        Cinema FindCinemaByCinemaName(string cinemaName, bool retrieveAssociation);

        IList<Cinema> FindAllCinemas(bool retrieveAssociation);
    }
}
