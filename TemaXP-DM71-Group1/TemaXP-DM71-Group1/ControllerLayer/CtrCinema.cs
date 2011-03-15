using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.ControllerLayer
{
    public class CtrCinema
    {
        public Cinema FindCinemaByName(Cinema c, bool retrieveAssociation)
        {
            IFDBCinema dbCinema = new DBCinema();
            return dbCinema.FindCinema(c, retrieveAssociation);
        }

        public void InsertCinema(string cinemaName, int noOfRows)
        {
            IFDBCinema dbCinema = new DBCinema();
            Cinema cObj = new Cinema();
            cObj.CinemaName = cinemaName;
            cObj.NoOfRows = noOfRows;
            cObj.NoOfSeats = 0;
            dbCinema.InsertCinema(cObj);
        }

        public void AddSeatsToRow(Cinema c, int rowNumber, int noOfSeats)
        {
            for(int i = 0; i < noOfSeats; i++)
            {
                c.Rows[rowNumber].Seats.Add(i);
            }
        }

        public void UpdateCinema(Cinema c, string cinemaName)
        {
            IFDBCinema dbCinema = new DBCinema();
            c.CinemaName = cinemaName;
            dbCinema.UpdateCinema(currentNoOfCinema, cObj);
        }

        public void DeleteCinema(Cinema c)
        {
            IFDBCinema dbCinema = new DBCinema();
            dbCinema.DeleteCinema(c);
        }
    }
}
