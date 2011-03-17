using System;
using System.Collections.Generic;
using System.Data.Common;
using TemaXP_DM71_Group1_ServiceLib.ModelLayer;

namespace TemaXP_DM71_Group1_ServiceLib.DBLayer
{
    public class DBMovie : IFDBMovie
    {
        private DbCommand command;
        private DbConnection conn;
        private DbProviderFactory dbFactory;
        private String provider = null;
        private String connStr = null;
        private DbDataReader dbReader = null;

        public DBMovie()
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

        public void InsertMovie(Movie m)
        {
            conn.Open();
             String sql = "INSERT INTO movie(releasedate, title, distributor, arrivaldate, returndate, duration, director, actors, moviedescription)  VALUES('"
                + m.ReleaseDate + "','"
                + m.Title + "','"
                + m.Distributor + "','"
                + m.ArrivalDate + "','"
                + m.ReturnDate + "','"
                + m.Duration + "','"
                + m.Director + "','"
                + m.Actors + "','"
                + m.MovieDescription + "')";

            Console.WriteLine("insert : " + sql);
            try
            { // insert new movie
                command = CreateCommand(sql);
                
                dbReader = command.ExecuteReader();

                
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in movie db: " + ex);
            }//end catch
            conn.Close();
        }

        public void DeleteMovie(Movie m)
        {
            conn.Open();
            String sql = "DELETE FROM movie "
                         + " WHERE id = " + m.Id;
            Console.WriteLine("Delete query:" + sql);
            try 
            { // delete movie
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Delete exception in movie db: " + ex);
            }//end catch
            conn.Close();
        }

        public void UpdateMovie(Movie m)
        {
            Movie mm = m;
            
            conn.Open();

            String sql = "UPDATE Movie SET "
                    + "ReleaseDate = '" + mm.ReleaseDate + "', " 
                    + "Title = '" + m.Title + "', "
                    + "Distributor = '" + m.Distributor + "', "
                    + "ArrivalDate = '" + m.ArrivalDate + "', "
                    + "ReturnDate = '" + m.ReturnDate + "', "
                    + "Duration = '" + m.Duration + "', "
                    + "Director = '" + m.Director + "', "
                    + "Actors = '" + m.Actors + "', "
                    + "MovieDescription = '" + m.MovieDescription + "' "
                    + "WHERE Id = " + m.Id;
            Console.WriteLine("Update query:" + sql);
            try
            { // update movie
                command = CreateCommand(sql);
                dbReader = command.ExecuteReader();

            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Update exception in movie db: " + ex);
            }//end catch

            conn.Close();
        }

        public Movie FindMovieByTitle(string title, bool retrieveAssociation)
        {
            conn.Open();
            Movie m = new Movie();
            String sql = "SELECT * FROM movie WHERE title = '" + title + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                m = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return m;
        }

        public Movie FindMovieById(Movie m, bool retrieveAssociation)
        {
            conn.Open();
            Movie nm = new Movie();
            String sql = "SELECT * FROM movie WHERE id = '" + m.Id + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                nm = CreateSingle(dbReader, retrieveAssociation);
            }

            conn.Close();
            return nm;
        }

        public IList<Movie> FindAllMovies(bool retrieveAssociation)
        {
            conn.Open();
            
            IList<Movie> movieList = new List<Movie>();
            string sql = "SELECT * FROM Movie";
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            dbReader = command.ExecuteReader();

            movieList = CreateList(dbReader, sql, retrieveAssociation);

            conn.Close();
            return movieList;
        }

        private Movie CreateSingle(DbDataReader dbReader, bool retrieveAssociation)
        {
            Movie mm = new Movie();
            try
            {
                mm.Id = dbReader.GetInt32(0);
                mm.ReleaseDate = checkDate(dbReader.GetDateTime(1).ToShortDateString());
                mm.Title = dbReader.GetString(2);
                mm.Distributor = dbReader.GetString(3);
                mm.ArrivalDate = checkDate(dbReader.GetDateTime(4).ToShortDateString());
                mm.ReturnDate = checkDate(dbReader.GetDateTime(5).ToShortDateString());
                TimeSpan ts = (TimeSpan)dbReader.GetProviderSpecificValue(6);
                mm.Duration = ts.ToString();
                mm.Director = dbReader.GetString(7);
                mm.Actors = dbReader.GetString(8);
                mm.MovieDescription = dbReader.GetString(9);

                if(retrieveAssociation)
                {

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("building movie object" + e);
            }
            return mm;
        }

        private IList<Movie> CreateList(DbDataReader dbReader, string sql, bool retrieveAssociation)
        {

          IList<Movie> list = new List<Movie>();


            Console.WriteLine("DbMovie List" + sql);
            try
            { // read from movie
                
               
                while (dbReader.Read())
                {
                    list.Add(CreateSingle(dbReader, retrieveAssociation));
                }//end while
            
            }//end try
            catch (Exception e)
            {
                Console.WriteLine("Query exception - select movie : " + e.Message);
                
            }//end catch
            
          return list;
        }

        private DbCommand CreateCommand(String sql)
        {
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            return command;
        }


        public Movie FindMovieByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Movie FindMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Movie> FindAllMovies()
        {
            throw new NotImplementedException();
        }

        private string checkDate(string date)
        {
            string reverse = date;
            if(date.Substring(2, 1).Equals("-"))
            {
                string year = date.Substring(6, 4);
                string month = date.Substring(3, 2);
                string day = date.Substring(1, 2);
                reverse = year + "-" + month + "-" + day;
            }//end if
            return reverse;
        }
    }
}
