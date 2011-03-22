using System;
using System.Collections.Generic;
using System.Data.Common;
using TemaXP_WCFServiceLib.ModelLayer;

namespace TemaXP_WCFServiceLib.DBLayer
{
    public class DBShow : IFDBShow
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

        public void InsertShow(Show s)
        {
            conn.Open();
            String sql = "INSERT INTO show (MovieStartTime, ShowDate, MovieID)  VALUES('"
               + s.MovieStartTime + "','"
               + s.ShowDate + "','"
               + s.Movie.Id + "')";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new show
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();


            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in show db: " + ex);
                throw;
            }//end catch
            conn.Close();
        }

        public void DeleteShow(Show s)
        {
            conn.Open();
            string sql = "DELETE FROM show "
                + " WHERE id = " + s.Id;
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

        public void UpdateShow(Show s)
        {
            conn.Open();

            String sql = "UPDATE Show SET "
                    + "MovieStartTime = '" + s.MovieStartTime + "', "
                    + "ShowDate = '" + s.ShowDate + "', "
                    + "MovieID = " + s.Movie.Id + " "
                    + "WHERE Id = " + s.Id;
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

        public Show FindShowByMovieId(Movie m, bool retrieveAssociation)
        {
            conn.Open();
            Show s = new Show();
            String sql = "SELECT * FROM show WHERE movieid = '" + m.Id + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return s;
        }
        
        private DbCommand CreateCommand(String sql)
        {
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            return command;
        }


        public Show FindShowByMovieIdAndShowDate(Movie m, string date, bool retrieveAssociation)
        {
            conn.Open();
            Show s = new Show();
            String sql = "SELECT * FROM show WHERE MovieId = '" + m.Id + "' AND ShowDate = '" + date + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return s;
        }

        public IList<Show> FindAllShows(bool retrieveAssociation)
        {
            conn.Open();
            IList<Show> showList = new List<Show>();
            string sql = "SELECT * FROM show";
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            showList = CreateList(dbReader, sql, retrieveAssociation);

            conn.Close();
            return showList;
        }

        public IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation)
        {
            conn.Open();
            IList<Show> sList = new List<Show>();
            String sql = "SELECT * FROM show WHERE Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)";
            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            sList = CreateList(dbReader, sql, retrieveAssociation);
            conn.Close();
            return sList;
        }

        public Show FindShowById(Show show, bool retrieveAssociation)
        {
            conn.Open();
            Show s = new Show();
            string sql = "SELECT * FROM show WHERE ShowId = '" + show.Id ;
            
            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return s;
        }

        
        public IList<Show> FindShowsByCinemaId(Cinema c, bool retrieveAssociation)
        {
            conn.Open();
            IList<Show> sList = new List<Show>();
            string sql = "SELECT * FROM Cinema_Show WHERE CinemaId = '" + c.Id;

            command = CreateCommand(sql);

            dbReader = command.ExecuteReader();

            sList = CreateList(dbReader, sql, retrieveAssociation);
            conn.Close();
            return sList;
        }

        private string checkDate(string date)
        {
            string reverse = date;
            if (date.Substring(2, 1).Equals("-"))
            {
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(1, 2);
                reverse = year + "-" + month + "-" + day;
            }//end if
            return reverse;
        }

        private IList<Show> CreateList(DbDataReader dbRead, string sql, bool retrieveAssociation)
        {

            IList<Show> list = new List<Show>();

            Console.WriteLine("DbShow List" + sql);
            try
            { // read from Show


                while (dbRead.Read())
                {
                    list.Add(CreateSingle(dbRead, retrieveAssociation));
                }//end while

            }//end try
            catch (Exception e)
            {
                Console.WriteLine("Query exception - select Row : " + e.Message);

            }//end catch

            return list;
        }

        private Show CreateSingle(DbDataReader dbReader, bool retriveAssociation)
        {
            Show s = new Show();
            try
            {
                s.Id = dbReader.GetInt32(0);
                TimeSpan ts = (TimeSpan)dbReader.GetProviderSpecificValue(1);
                s.MovieStartTime = ts.ToString();
                s.ShowDate = checkDate(dbReader.GetDateTime(2).ToShortDateString());
                Movie m = new Movie();
                m.Id = dbReader.GetInt32(3);
                if (retriveAssociation)
                {
                    IFDBMovie dbMovie = new DBMovie();
                    s.Movie = dbMovie.FindMovieById(m, false);
                }
                s.Movie = m;
            }
            catch (Exception e)
            {
                Console.WriteLine("building show object" + e);
                throw;
            }
            return s;
        }

        public void InsertCinemaShow(Cinema c, Show s)
        {
            conn.Open();
            String sql = "INSERT INTO Cinema_Show (ShowID, CinamaID)  VALUES("
               + s.Id + ", "
               + c.Id + ")";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new show
                command = CreateCommand(sql);

                dbReader = command.ExecuteReader();


            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in cinema_show db: " + ex);
                throw;
            }//end catch
            conn.Close();
        }

        public void DeleteCinemaShow(Cinema c, Show s)
        {
            conn.Open();
            string sql = "DELETE FROM Cinema_Show "
                + " WHERE ShowID = " + s.Id + " AND CinemaID = " + c.Id;
            Console.WriteLine("Delete query:" + sql);
            try
            { // delete cinema show
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Delete exception in show db: " + ex);
            }//end catch
            conn.Close();
        }

        public void UpdateCinemaShow(Cinema oldc, Show olds, Cinema newc, Show news)
        {
            conn.Open();

            String sql = "UPDATE Cinema_Show SET ShowID = " + news.Id + ", CinemaID = " + newc.Id + " WHERE Id in(SELECT Id FROM Cinema_Show WHERE ShowID =" + olds.Id + " AND CinemaID = " + oldc.Id + " )" ;
            Console.WriteLine("Update query:" + sql);
            try
            { // update Cinema_show
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();

            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Update exception in Cinema_show db: " + ex);
            }//end catch

            conn.Close();
        }
    }
}
