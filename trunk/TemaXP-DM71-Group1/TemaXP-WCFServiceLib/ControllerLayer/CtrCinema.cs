using System.Collections.Generic;
using TemaXP_WCFServiceLib.DBLayer;
using TemaXP_WCFServiceLib.ModelLayer;
using TemaXP_WCFServiceLib;

namespace TemaXP_WCFServiceLib.ControllerLayer
{
    public class CtrCinema : IService1
    {
        public Cinema FindCinemaByName(string cinemaName, bool retrieveAssociation)
        {
            IFdbCinema dbCinema = new DBCinema();
            return dbCinema.FindCinemaByCinemaName(cinemaName, retrieveAssociation);
        }

        public Cinema FindCinemaByNoOfSeats(int noOfSeats, bool retrieveAssociation)
        {
            IFdbCinema dbCinema = new DBCinema();
            return dbCinema.FindCinemaByNoOfSeats(noOfSeats, retrieveAssociation);
        }

        public IList<Cinema> FindAllCinemas(bool retrieveAssociation)
        {
            IFdbCinema dbCinema = new DBCinema();
            IList<Cinema> cinemaList = dbCinema.FindAllCinemas(retrieveAssociation);
            return cinemaList;
        }

        public IList<Cinema> FindAllCinemasByShowID(Show s, bool retrieveAssociation)
        {
            IFdbCinema dbCinema = new DBCinema();
            IList<Cinema> cinemaList = dbCinema.FindCinemasByShowID(s, retrieveAssociation);
            return cinemaList;
        }

        public void InsertCinema(string cinemaName, int noOfRows)
        {
            IFdbCinema dbCinema = new DBCinema();
            Cinema cObj = new Cinema();
            cObj.CinemaName = cinemaName;
            cObj.NoOfRows = noOfRows;
            cObj.NoOfSeats = 0;
            dbCinema.InsertCinema(cObj);
        }

        public void AddSeatsToRow(Cinema c, int rowNumber, int noOfSeats)
        {
            for (int i = 0; i < noOfSeats; i++)
            {
                c.Rows[rowNumber].Seats.Add(i);
            }
        }

        public void UpdateCinema(Cinema c, string cinemaName)
        {
            IFdbCinema dbCinema = new DBCinema();
            c.CinemaName = cinemaName;
            dbCinema.UpdateCinema(c);
        }

        public void DeleteCinema(Cinema c)
        {
            IFdbCinema dbCinema = new DBCinema();
            dbCinema.DeleteCinema(c);
        }

        public void InsertRow(Cinema c, int noOfSeats, int rowNo)
        {
            IFdbRow dbRow = new DBRow();
            Row rObj = new Row();
            rObj.Cinema = c;
            rObj.NoOfSeats = noOfSeats;
            rObj.RowNo = rowNo;
            dbRow.InsertRow(rObj);
        }

        public void DeleteRow(Row row)
        {
            IFdbRow dbRow = new DBRow();
            dbRow.DeleteRow(row);
        }

        public void UpdateRow(Row row)
        {
            IFdbRow dbRow = new DBRow();
            Row rObj = row;
            dbRow.UpdateRow(rObj);
        }

        public Row FindRowByRowNoAndCinema(int rowNo, Cinema cinema, bool retrieveAssociation)
        {
            IFdbRow dbRow = new DBRow();
            return dbRow.FindRowByRowNoAndCinema(rowNo, cinema, retrieveAssociation);
        }

        public Row FindRowById(Row row, bool retrieveAssociation)
        {
            IFdbRow dbRow = new DBRow();
            return dbRow.FindRowById(row, retrieveAssociation);
        }

        public IList<Row> FindRowsByCinemaId(Cinema c, bool retrieveAssociation)
        {
            IFdbRow dbRow = new DBRow();
            IList<Row> rowList = dbRow.FindRowsByCinemaId(c, retrieveAssociation);
            return rowList;
        }

        public IList<Row> FindAllRows(bool retrieveAssociation)
        {
            IFdbRow dbRow = new DBRow();
            IList<Row> rowList = dbRow.FindAllRows(retrieveAssociation);
            return rowList;
        }
    }
}
