using TemaXP_DM71_Group1.DBLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TemaXP_DM71_Group1.ModelLayer;
using System.Collections.Generic;

namespace TestCinemas
{
    /// <summary>
    ///This is a test class for DBCinemaTest and is intended
    ///to contain all DBCinemaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DBCinemaTest
    {
        private IFdbCinema dbc;
    

        public DBCinemaTest()
        {
            dbc = new DBCinema();
        }

       /// <summary>
        ///A test for InsertCinema
        ///</summary>
        [TestMethod()]
        public void InsertCinemaTest()
        {
            dbc = new DBCinema(); 
            Cinema c = new Cinema();
            string cinemaName = "TestInsert";
            int noOfSeats = 10;
            int noOfRows = 2;
            IList<Row> rs = new List<Row>();

            c.CinemaName = cinemaName;
            c.NoOfSeats = noOfSeats;
            c.NoOfRows = noOfRows;
            c.Rows = rs;
           
            Cinema result = new Cinema();
            try
            {
                dbc.InsertCinema(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbc.FindCinemaByCinemaName(cinemaName, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(cinemaName, result.CinemaName);
            Assert.AreEqual(noOfSeats, result.NoOfSeats);
            Assert.AreEqual(noOfRows, result.NoOfRows);
            Assert.AreEqual(rs.Count, result.Rows.Count);


            MyTestCleanup(cinemaName);
        }

        /// <summary>
        ///A test for FindCinemaByCinemaName
        ///</summary>
        [TestMethod()]
        public void FindCinemaByCinemaNameTest()
        {
            dbc = new DBCinema();
            Cinema c = new Cinema();
            string cinemaName = "TestFind";
            int noOfSeats = 10;
            int noOfRows = 2;
            IList<Row> rs = new List<Row>();

            c.CinemaName = cinemaName;
            c.NoOfSeats = noOfSeats;
            c.NoOfRows = noOfRows;
            c.Rows = rs;

            Cinema result = new Cinema();
            try
            {
                dbc.InsertCinema(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbc.FindCinemaByCinemaName(cinemaName, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(cinemaName, result.CinemaName);
            Assert.AreEqual(noOfSeats, result.NoOfSeats);
            Assert.AreEqual(noOfRows, result.NoOfRows);
            Assert.AreEqual(rs.Count, result.Rows.Count);


            MyTestCleanup(cinemaName);
        }

        /// <summary>
        ///A test for DeleteCinema
        ///</summary>
        [TestMethod()]
        public void DeleteCinemaTest()
        {
            dbc = new DBCinema();
            Cinema c = new Cinema();
            string cinemaName = "TestDelete";
            int noOfSeats = 10;
            int noOfRows = 2;
            IList<Row> rs = new List<Row>();

            c.CinemaName = cinemaName;
            c.NoOfSeats = noOfSeats;
            c.NoOfRows = noOfRows;
            c.Rows = rs;

            Cinema find = new Cinema();
            Cinema result = new Cinema();
            try
            {
                dbc.InsertCinema(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                find = dbc.FindCinemaByCinemaName(cinemaName, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbc.DeleteCinema(find);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbc.FindCinemaByCinemaName(cinemaName, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(null, result.CinemaName);
            Assert.AreEqual(0, result.NoOfSeats);
            Assert.AreEqual(0, result.NoOfRows);
//            Assert.AreEqual(rs.Count, result.Rows.Count);
            
        }


        /// <summary>
        ///A test for FindAllShows
        ///</summary>
        [TestMethod()]
        public void FindAllCinemasTest()
        {
            dbc = new DBCinema();

            Cinema c = new Cinema();
            string cinemaName = "TestFindAll";
            int noOfSeats = 10;
            int noOfRows = 2;
            IList<Row> rs = new List<Row>();

            c.CinemaName = cinemaName;
            c.NoOfSeats = noOfSeats;
            c.NoOfRows = noOfRows;
            c.Rows = rs;
            IList<Cinema> current = new List<Cinema>();
            IList<Cinema> result = new List<Cinema>();
            try
            {
                current = dbc.FindAllCinemas(false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbc.InsertCinema(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbc.FindAllCinemas(false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(current.Count + 1, result.Count);

            MyTestCleanup(cinemaName);
        }

        

//        /// <summary>
//        ///A test for FindCinemaByShowID
//        ///</summary>
//        [TestMethod()]
//        public void FindCinemaByShowIDTest()
//        {
//            dbc = new DBCinema();
//
//            Cinema c = new Cinema();
//            Show s = new Show();
//            s.Id = 1;
//            IList<Cinema> result = new List<Cinema>();
//            try
//            {
//                result = dbc.FindCinemasByShowID(s, false);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("virker ikke " + e.Message);
//            }
//
//            Assert.AreEqual(3, result.Count);
//
//          
//        }

        
        /// <summary>
        ///A test for UpdateCinema
        ///</summary>
        [TestMethod()]
        public void UpdateCinemaTest()
        {
            dbc = new DBCinema();
            Cinema c = new Cinema();
            string cinemaName = "TestUpdate";
            string cinemaNameUpdate = "UpdatedTestUpdate";
            int noOfSeats = 10;
            int noOfRows = 2;
            IList<Row> rs = new List<Row>();

            c.CinemaName = cinemaName;
            c.NoOfSeats = noOfSeats;
            c.NoOfRows = noOfRows;
            c.Rows = rs;

            Cinema toUpdate = new Cinema();
            Cinema result = new Cinema();
            try
            {
                dbc.InsertCinema(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                toUpdate = dbc.FindCinemaByCinemaName(cinemaName, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            toUpdate.CinemaName = cinemaNameUpdate;

            try
            {
                dbc.UpdateCinema(toUpdate);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbc.FindCinemaByCinemaName(cinemaNameUpdate, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(toUpdate.Id, result.Id);
            Assert.AreEqual(toUpdate.CinemaName, result.CinemaName);
            Assert.AreEqual(toUpdate.NoOfSeats, result.NoOfSeats);
            Assert.AreEqual(toUpdate.NoOfRows, result.NoOfRows);
            Assert.AreEqual(toUpdate.Rows.Count, result.Rows.Count);

            MyTestCleanup(cinemaNameUpdate);
        }

        public void MyTestCleanup(string cinemaName)
        {

            Cinema c = new Cinema();
            try
            {
                c = dbc.FindCinemaByCinemaName(cinemaName, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbc.DeleteCinema(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }
        }
    }
}
