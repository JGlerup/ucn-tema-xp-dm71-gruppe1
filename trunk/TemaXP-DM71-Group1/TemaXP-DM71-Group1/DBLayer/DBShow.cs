using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;
using System.Configuration;

namespace TemaXP_DM71_Group1.DBLayer
{
    public class DBShow
    {
        private DbCommand command;
        private DbConnection conn;
        private DbProviderFactory dbFactory;
        private String provider = null;
        private String connStr = null;
        private DbDataReader dbReader = null;

        public DBShow()
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

        //public IList<Show> sortShowByDate(bool retrieveAssosiation)
        //{
        //    //IList<Show> sObj = new IList();
            
        //    //sObj = singleWhere("SELECT * FROM show WHERE Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)", retrieveAssociation);

        //    return miscWhere("Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)", retrieveAssociation);
        //}

        public void InsertShow(Show m)
        {
            conn.Open();
            String sql = "INSERT INTO show(MovieStartTime, MovieID, ShowDate)  VALUES('"
               + m.ReleaseDate + "','"
               + m.Title + "','"
               + m.Distributor + "','"
               + m.ArrivalDate + "','"
               + m.ReturnDate + "','"
               + m.Duration + "','"
               + m.Director + "','"
               + m.Actors + "','"
               + m.ShowDescription + "')";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new show
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();


            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in show db: " + ex);
            }//end catch
            conn.Close();
        }

        public void DeleteShow(String title)
        {
            conn.Open();
            String sql = "DELETE FROM show "
                + " WHERE title = " + title;
            Console.WriteLine("Delete query:" + sql);
            try
            { // delete show
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Delete exception in show db: " + ex);
            }//end catch
            conn.Close();
        }

        public void UpdateShow(Show m)
        {
            Show mm = m;

            conn.Open();

            String sql = "UPDATE Show SET "
                    + "ReleaseDate = '" + mm.ReleaseDate + "', "
                    + "Title = '" + m.Title + "', "
                    + "Distributor = '" + m.Distributor + "', "
                    + "ArrivalDate = '" + m.ArrivalDate + "', "
                    + "ReturnDate = '" + m.ReturnDate + "', "
                    + "Duration = '" + m.Duration + "', "
                    + "Director = '" + m.Director + "', "
                    + "Actors = '" + m.Actors + "', "
                    + "ShowDescription = '" + m.ShowDescription + "' "
                    + "WHERE Id = " + m.Id;
            Console.WriteLine("Update query:" + sql);
            try
            { // update show
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();

            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Update exception in show db: " + ex);
            }//end catch

            conn.Close();
        }

        public Show FindShow(string title)
        {
            conn.Open();
            Show m = new Show();
            String sql = "SELECT * FROM show where title = '" + title + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                m = CreateSingle(dbReader);
            }

            conn.Close();
            return m;
        }

        public IList<Show> FindAllShows()
        {

            conn.Open();
            List<Show> showList = new List<Show>();
            String sql = "SELECT * FROM film";
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            DbDataReader dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                showList.Add(CreateSingle(dbReader));
            }

            conn.Close();
            return showList;
        }

        private Show CreateSingle(DbDataReader dbReader)
        {
            Show mm = new Show();
            try
            {
                mm.Id = dbReader.GetInt32(0);
                mm.ReleaseDate = dbReader.GetString(1);
                mm.Title = dbReader.GetString(2);
                mm.Distributor = dbReader.GetString(3);
                mm.ArrivalDate = dbReader.GetString(4);
                mm.ReturnDate = dbReader.GetString(5);
                TimeSpan ts = (TimeSpan)dbReader.GetProviderSpecificValue(6);
                mm.Duration = ts.ToString();
                mm.Director = dbReader.GetString(7);
                mm.Actors = dbReader.GetString(8);
                mm.ShowDescription = dbReader.GetString(9);
            }
            catch (Exception e)
            {
                Console.WriteLine("building show object" + e);
            }
            return mm;
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
