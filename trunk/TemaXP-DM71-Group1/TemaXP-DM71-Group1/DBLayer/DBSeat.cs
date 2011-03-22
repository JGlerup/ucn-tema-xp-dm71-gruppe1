using System;
using System.Collections.Generic;
using System.Data.Common;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public class DBSeat
    {
        private DbCommand command;
        private DbConnection conn;
        private DbProviderFactory dbFactory;
        private String provider = null;
        private String connStr = null;
        private DbDataReader dbReader = null;

        public DBSeat()
        {
            //            provider = ConfigurationManager.ConnectionStrings["TemaXP.Properties.Settings.DatabaseConnectionString"].ProviderName;
            //            connStr = ConfigurationManager.ConnectionStrings["TemaXP.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            connStr = "Data Source=balder.ucn.dk;initial catalog=DM71_2;User Id=DM71_2; Password=MaaGodt;";
            provider = "System.Data.SqlClient";

            dbFactory = DbProviderFactories.GetFactory(provider);

            conn = dbFactory.CreateConnection();
            conn.ConnectionString = connStr;

            Console.WriteLine("Database is open: {0}", conn.State);
        }

        public void InsertSeat(Seat s)
        {
            conn.Open();
            String sql = "INSERT INTO Seat (SeatNo, RowID, Taken, Reserved, BookingID)  VALUES('"
               + s.SeatNo + "', "
               + s.Row.Id + "', "
               + s.Taken + "', "
               + s.Reserved + "', "
               + s.Booking.Id + ")";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new seat
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in seat db: " + ex);
                throw;
            }//end catch
            conn.Close();
        }

        public Seat FindSeatBySeatNo(int seatNo, bool retrieveAssociation)
        {
            conn.Open();
            Seat s = new Seat();
            String sql = "SELECT * FROM Seat WHERE SeatNo = '" + seatNo + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return s;
        }

        public Seat FindSeatByID(int seatID, bool retrieveAssociation)
        {
            conn.Open();
            Seat s = new Seat();
            String sql = "SELECT * FROM Seat WHERE Id = '" + s.Id + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return s;
        }

        public void DeleteSeat(Seat s)
        {
            conn.Open();
            string sql = "DELETE FROM Seat "
                + " WHERE id = " + s.Id;
            Console.WriteLine("Delete query:" + sql);
            try
            { // delete seat
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Delete exception in seat db: " + ex);
            }//end catch
            conn.Close();
        }

        public void UpdateSeat(Seat s)
        {
            conn.Open();

            String sql = "UPDATE Seat SET "
                    + "SeatNo = '" + s.SeatNo + "', "
                    + "RowID = " + s.Row.Id + ", "
                    + "Taken = " + s.Taken + ", "
                    + "Reserved = " + s.Reserved + " "
                    + "WHERE Id = " + s.Id;
            Console.WriteLine("Update query:" + sql);
            try
            { // update show
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();

            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Update exception in seat db: " + ex);
            }//end catch

            conn.Close();
        }

        public IList<Seat> FindAllSeats(bool retrieveAssociation)
        {
            conn.Open();
            IList<Seat> seatList = new List<Seat>();
            string sql = "SELECT * FROM Seat";
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                seatList.Add(CreateSingle(dbReader, retrieveAssociation));
            }

            conn.Close();
            return seatList;
        }

        private Seat CreateSingle(DbDataReader dbReader, bool retrieveAssociation)
        {
            Seat s = new Seat();
            try
            {
                s.Id = dbReader.GetInt32(0);
                s.SeatNo = dbReader.GetInt32(1);
                Row r = new Row();
                r.Id = dbReader.GetInt32(2);
                if(retrieveAssociation)
                {
                    IFdbRow dbRow = new DBRow();
                    dbRow.FindRowById(r, false);
                }
                s.Row = r;
                s.Taken = dbReader.GetString(3);
                s.Reserved = dbReader.GetString(4);
                Booking b = new Booking();
                b.Id = dbReader.GetInt32(5);
                if(retrieveAssociation)
                {
//                    IFdbBooking dbBooking = new DBBooking();
//                    dbBooking.FindBookingById(b, false);
                }
                s.Booking = b;
            }
            catch (Exception e)
            {
                Console.WriteLine("building show object" + e);
            }
            return s;
        }

        private DbCommand CreateCommand(String sql)
        {
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            return command;
        }
    }
}
