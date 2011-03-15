using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using TemaXP_DM71_Group1.ModelLayer;

namespace TemaXP_DM71_Group1.DBLayer
{
    class DBCinema : IFdbCinema
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
            throw new NotImplementedException();
        }

        public void DeleteCinema(Cinema c)
        {
            throw new NotImplementedException();
        }

        public void UpdateCinema(Cinema c)
        {
            throw new NotImplementedException();
        }

        public Cinema FindCinemaByNoOfCinema(int noOfCinema, bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public Cinema FindCinemaByShowID(Show s, bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        public IList<Cinema> FindAllShows(bool retrieveAssociation)
        {
            throw new NotImplementedException();
        }

        private Cinema CreateSingle(DbDataReader dbReader, bool retriveAssociation)
        {
            Cinema c = new Cinema();
            try
            {
                c.Id = dbReader.GetInt32(0);
                c.CinemaName =
                TimeSpan ts = (TimeSpan)dbReader.GetProviderSpecificValue(1);
                s.MovieStartTime = ts.ToString();
                s.ShowDate = dbReader.GetDateTime(2).ToShortDateString();
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
            }
            return s;
        }
    }
}
