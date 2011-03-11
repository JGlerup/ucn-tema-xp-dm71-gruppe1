using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;
using System.Configuration;

namespace TemaXP_DM71_Group1.DBLayer
{
    public class DbMovie : IFdbMovie
    {
        private DbCommand command;
        private DbConnection conn;
        private DbProviderFactory dbFactory;
        private String provider = null;
        private String connStr = null;
        private DbDataReader dbReader = null;

        public DbMovie()
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

        public void DeleteMovie(String title)
        {
            conn.Open();
            String sql = "DELETE FROM movie "
                + " WHERE title = " + title;
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

        public Movie FindMovie(string title)
        {
            conn.Open();
            Movie m = new Movie();
            String sql = "SELECT * FROM movie where title = '" + title + "'";

            command = CreateCommand(sql);
            dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                m = CreateSingle(dbReader);
            }

            conn.Close();
            return m;
        }

        public IList<Movie> FindAllMovies()
        {
            throw new NotImplementedException();
        }

        private Movie CreateSingle(DbDataReader dbReader)
        {
            Movie mm = new Movie();
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
                mm.MovieDescription = dbReader.GetString(9);
            }
            catch (Exception e)
            {
                Console.WriteLine("building movie object" + e);
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
