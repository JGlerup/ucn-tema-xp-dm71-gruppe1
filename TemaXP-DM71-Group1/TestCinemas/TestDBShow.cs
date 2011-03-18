using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.DBLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TestCinemas
{
    [TestClass]
    public class TestDBShow
    {
         private IFDBShow dbs;

        public TestDBShow()
        {

        }


        [TestMethod]
        public void TestInsert()
        {
            dbs = new DbShow();
            
            Show s = new Show();
            string movieStartTime = "13:30:00";
            string showDate = "2012-03-19";
            string showDateReverse = "19-03-2012";
            Movie m = new Movie();
            m.Id = 1;
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = m;

            
            
            Show result = new Show();
            try
            {
                dbs.InsertShow(s); 
            }
            catch(Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " +e.Message);
            }


            Assert.AreEqual(movieStartTime, result.MovieStartTime);
            Assert.AreEqual(showDateReverse, result.ShowDate);
            Assert.AreEqual(s.Movie.Id, result.Movie.Id);
           

            MyTestCleanup(m, showDate);
            
        }

        [TestMethod]
        public void TestFindMovie()
        {
            dbs = new DbShow();

            Show s = new Show();
            string movieStartTime = "14:40:00";
            string showDate = "2012-03-23";
            string showDateReverse = "23-03-2012";
            Movie m = new Movie();
            m.Id = 1;
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = m;



            Show result = new Show();
            try
            {
                dbs.InsertShow(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(movieStartTime, result.MovieStartTime);
            Assert.AreEqual(showDateReverse, result.ShowDate);
            Assert.AreEqual(m.Id, result.Movie.Id);


            MyTestCleanup(m, showDate);

        }

        [TestMethod]
        public void TestDeleteShow()
        {
            dbs = new DbShow();

            Show s = new Show();
            string movieStartTime = "15:50:00";
            string showDate = "2012-12-01";
            string showDateReverse = "01-12-2012";
            Movie m = new Movie();
            m.Id = 2;
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = m;
            Show find = new Show();
            Show result = new Show();
            try
            {
                dbs.InsertShow(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                find = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbs.DeleteShow(find);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(null, result.MovieStartTime);
            Assert.AreEqual(0, result.Id);

         }

        [TestMethod]
        public void TestUpdateMovie()
        {
            dbs = new DbShow();

            Show s = new Show();
            string movieStartTime = "15:50:00";
            string showDate = "2012-12-01";
            string showDateReverse = "01-12-2012";
            Movie m = new Movie();
            m.Id = 2;
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = m;
            Show find = new Show();
            Show result = new Show();
            try
            {
                dbs.InsertShow(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }
            
            try
            {
                find = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            m.Id = 1;
            s = find;
            s.ShowDate = showDate;
            s.Movie = m;
            try
            {
                dbs.UpdateShow(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(find.Id, result.Id);
            Assert.AreEqual(showDateReverse, result.ShowDate);
            Assert.AreEqual(find.MovieStartTime, result.MovieStartTime);
            Assert.AreEqual(m.Id, result.Movie.Id);

            MyTestCleanup(m, showDate);

        }

        [TestMethod]
        public void TestFindList()
        {
            IList<Movie> movies = new List<Movie>();
            dbs = new DbShow();

            Show s = new Show();
            string movieStartTime = "15:50:00";
            string showDate = "2012-12-12";
            Movie m = new Movie();
            m.Id = 2;
            s.MovieStartTime = movieStartTime;
            s.ShowDate = showDate;
            s.Movie = m;
            IList<Show> current = new List<Show>();
            IList<Show> result = new List<Show>();
            try
            {
                current = dbs.FindAllShows(false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }
            
            try
            {
                dbs.InsertShow(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbs.FindAllShows(false);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(current.Count +1, result.Count);
            
            MyTestCleanup(m, showDate);
        }
            

        public void MyTestCleanup(Movie m, string showDate)
        {
            
            Show s = new Show();
            try
            {
                s = dbs.FindShowByMovieIdAndShowDate(m, showDate, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbs.DeleteShow(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }
        }

    }
}
