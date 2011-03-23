using System.Collections.Generic;
using TemaXP_Groupe1_WcfService1.ModelLayer;

namespace TemaXP_Groupe1_WcfService1.DBLayer
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
