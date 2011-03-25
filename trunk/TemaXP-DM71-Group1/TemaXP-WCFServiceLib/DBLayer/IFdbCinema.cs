using System.Collections.Generic;
using TemaXP_WCFServiceLib.ModelLayer;

namespace TemaXP_WCFServiceLib.DBLayer
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
