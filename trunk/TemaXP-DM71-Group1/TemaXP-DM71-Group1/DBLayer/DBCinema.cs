using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    public class DBCinema : IFdbCinema
    {
        private DbCommand command;
        private DbConnection conn;
        private DbProviderFactory dbFactory;
        private String provider = null;
        private String connStr = null;
        private DbDataReader dbReader = null;

        public DBCinema()
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

        public void InsertCinema(Cinema c)
        {
            conn.Open();
            String sql = "INSERT INTO Cinema (CinemaName, NoOfSeats, NoOfRows)  VALUES('"
               + c.CinemaName + "', "
               + c.NoOfSeats + ", "
               + c.NoOfRows + ")";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new cinema
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in cinema db: " + ex);
                throw;
            }//end catch
            conn.Close();
        }

        public Cinema FindCinemaByCinemaName(string cinemaName, bool retrieveAssociation)
        {
            conn.Open();
            Cinema c = new Cinema();
            String sql = "SELECT * FROM Cinema WHERE cinemaName = '" + cinemaName + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                c = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return c;
        }

        public Cinema FindCinemaByNoOfSeats(int noOfSeats, bool retrieveAssociation)
        {
            conn.Open();
            Cinema c = new Cinema();
            String sql = "SELECT * FROM Cinema WHERE NoOfSeats = " + noOfSeats;

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                c = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return c;
        }

        public void DeleteCinema(Cinema c)
        {
            conn.Open();
            string sql = "DELETE FROM Cinema "
                + " WHERE id = " + c.Id;
            Console.WriteLine("Delete query:" + sql);
            try
            { // delete cinema
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Delete exception in cinema db: " + ex);
            }//end catch
            conn.Close();
        }

        public void UpdateCinema(Cinema c)
        {
            conn.Open();

            String sql = "UPDATE Cinema SET "
                    + "cinemaName = '" + c.CinemaName + "', "
                    + "noOfSeats = " + c.NoOfSeats + ", "
                    + "noOfRows = " + c.NoOfRows + " "
                    + "WHERE Id = " + c.Id;
            Console.WriteLine("Update query:" + sql);
            try
            { // update show
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();

            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Update exception in cinema db: " + ex);
            }//end catch

            conn.Close();
        }



        public IList<Cinema> FindCinemasByShowID(Show s, bool retrieveAssociation)
        {
            conn.Open();
            IList<Cinema> cinemaList = new List<Cinema>();
            string sql = "SELECT * FROM Cinema WHERE Id in(SELECT CinemaId FROM Cinema_Show WHERE ShowId =  " + s.Id + ")";
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                cinemaList.Add(CreateSingle(dbReader, retrieveAssociation));
            }

            conn.Close();
            return cinemaList;
        }

        public IList<Cinema> FindAllCinemas(bool retrieveAssociation)
        {
            conn.Open();
            IList<Cinema> cinemaList = new List<Cinema>();
            string sql = "SELECT * FROM Cinema";
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                cinemaList.Add(CreateSingle(dbReader, retrieveAssociation));
            }

            conn.Close();
            return cinemaList;
        }

        private Cinema CreateSingle(DbDataReader dbReader, bool retriveAssociation)
        {
            Cinema c = new Cinema();
            try
            {
                c.Id = dbReader.GetInt32(0);
                c.CinemaName = dbReader.GetString(1);
                c.NoOfSeats = dbReader.GetInt32(2);
                c.NoOfRows = dbReader.GetInt32(3);
                IList<Row> rs = new List<Row>();
                if (retriveAssociation)
                {
//                    IFdbRow dbRow = new DBRow();
//                    rs = dbRow.findRowsById(c.Id, false)
                }
                c.Rows = rs;
            }
            catch (Exception e)
            {
                Console.WriteLine("building show object" + e);
            }
            return c;
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
