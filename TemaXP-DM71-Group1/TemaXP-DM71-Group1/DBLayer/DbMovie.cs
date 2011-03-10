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
//        private DbDataReader dbReader = null;

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
             String sql = "INSERT INTO film(id, releasedate, title, distributor, arrivaldate, returndate, duration, director, actors, moviedescription)  VALUES("
                + m.Id + ",'"
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
                command = dbFactory.CreateCommand();
                command.CommandText = sql;
                command.Connection = conn;

                DbDataReader dbReader = command.ExecuteReader();

                
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine("Insert exception in movie db: " + ex);
            }//end catch
            conn.Close();
        }

        public void DeleteMovie(Movie m)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(Movie m)
        {
            throw new NotImplementedException();
        }

        public Movie FindMovie(string title)
        {
            conn.Open();
            Movie m = new Movie();
            String sql = "SELECT * FROM film where title = '" + title + "'";
            command = dbFactory.CreateCommand();
            command.CommandText = sql;
            command.Connection = conn;

            DbDataReader dbReader = command.ExecuteReader();

            while (dbReader.Read())
            {
                m = Create(dbReader);
            }

            conn.Close();
            return m;
        }

        public IList<Movie> FindAllMovies()
        {
            throw new NotImplementedException();
        }

        private Movie Create(DbDataReader dbReader)
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
                mm.Duration = dbReader.GetString(6);
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
    }
}
