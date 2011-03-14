using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;
using System.Configuration;

namespace TemaXP_DM71_Group1.DBLayer
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

        //public IList<Show> sortShowByDate(bool retrieveAssosiation)
        //{
        //    //IList<Show> sObj = new IList();
            
        //    //sObj = singleWhere("SELECT * FROM show WHERE Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)", retrieveAssociation);

        //    return miscWhere("Date_ BETWEEN (Select DATEADD(DAY, -1, GETDATE()) AS NewDate1) AND (SELECT DATEADD(Week,1,GETDATE()) AS NewDate)", retrieveAssociation);
        //}

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
            String sql = "DELETE FROM show "
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
                throw;
            }//end catch
            conn.Close();
        }

        public void UpdateShow(Show s)
        {
            conn.Open();

            String sql = "UPDATE Show SET "
                    + "MovieStartTime = '" + s.MovieStartTime + "', "
                    + "ShowDate = '" + s.ShowDate + "', "
                    + "MovieID = '" + s.Id + "', "
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

        public Show FindShowByMovieIdAndShowDate(Movie m, string date)
        {
            conn.Open();
            Show s = new Show();
            String sql = "SELECT * FROM show WHERE MovieId = '" + m.Id + "' AND ShowDate = '" + date + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader);
            }

            conn.Close();
            return s;
        }

        public Show FindShowByMovieId(Movie m)
        {
            conn.Open();
            Show s = new Show();
            String sql = "SELECT * FROM show WHERE movieid = '" + m.Id + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                s = CreateSingle(dbReader);
            }

            conn.Close();
            return s;
        }

        public IList<Show> FindAllShows()
        {

            conn.Open();
            List<Show> showList = new List<Show>();
            String sql = "SELECT * FROM show";
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

        public IList<Show> GetAllShowsOneWeekAhead()
        {
            throw new NotImplementedException();
        }

        private Show CreateSingle(DbDataReader dbReader)
        {
            Show s = new Show();
            try
            {
                s.Id = dbReader.GetInt32(0);
                TimeSpan ts = (TimeSpan) dbReader.GetProviderSpecificValue(1);
                s.MovieStartTime = ts.ToString();
                s.ShowDate = dbReader.GetDateTime(2).ToString();
                //get movie
//                IFDBMovie dbMovie = new DBMovie();
//                s.Movie = dbMovie.FindMovieById(dbReader.GetInt32(3));
                //end "get movie"
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


        public Show FindShowByMovieIdAndShowDate(Movie m, string date, bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public Show FindShowByMovieId(Movie m, bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public IList<Show> FindAllShows(bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public IList<Show> GetAllShowsOneWeekAhead(bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }
    }
}
