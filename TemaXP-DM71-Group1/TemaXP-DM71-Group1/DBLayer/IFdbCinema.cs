using System.Collections.Generic;
using TemaXP_DM71_Group1_ServiceLib.ModelLayer;

namespace TemaXP_DM71_Group1_ServiceLib.DBLayer
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
