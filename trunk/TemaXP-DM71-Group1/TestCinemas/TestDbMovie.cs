using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.DBLayer;
using TemaXP_DM71_Group1.ModelLayer;

namespace TestCinemas
{
    [TestClass]
    public class TestDbMovie
    {

        private IFdbMovie dbm;

        public TestDbMovie()
        {
            
        }

         

        [TestMethod]
        public void TestInsert()
        {
            dbm = new DbMovie();
            int id = 344;
            String releaseDate = "09.09.09";
            String title = "Sjov";
            String distributor = "xx";
            String arr = "xx";
            String ret = "xx";
            String dur = "xx";
            String dir = "xx";
            String actors = "Krbyr";
            String moDis = "xx";
            Movie nm = new Movie();
            nm.Id = id;
            nm.ReleaseDate = releaseDate;
            nm.Title = title;
            nm.Distributor = distributor;
            nm.ArrivalDate = arr;
            nm.ReturnDate = ret;
            nm.Duration = dur;
            nm.Director = dir;
            nm.Actors = actors;
            nm.MovieDescription = moDis;
            Movie result = new Movie();
            try
            {
                dbm.InsertMovie(nm);
            }
            catch(Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbm.FindMovie(title);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " +e.Message);
            }

            Assert.AreEqual(id, result.Id);
            Assert.AreEqual(releaseDate, result.ReleaseDate);
            Assert.AreEqual(title, result.Title);
            Assert.AreEqual(distributor, result.Distributor);
            Assert.AreEqual(arr, result.ArrivalDate);
            Assert.AreEqual(ret, result.ReturnDate);
            Assert.AreEqual(dur, result.Duration);
            Assert.AreEqual(dir, result.Director);
            Assert.AreEqual(actors, result.Actors);
            Assert.AreEqual(moDis, result.MovieDescription);
       }

        [TestMethod]
        public void TestFindMovie()
        {
            dbm = new DbMovie();
            String title = "Die Hard";
            String actors = "Erik G";
            Movie result = new Movie();
            try
            {
                result = dbm.FindMovie(title);
            }
            catch(Exception e)
            {
                Console.WriteLine("virkede ikke" + e.Message);
            }

            Assert.AreEqual(title, result.Title);
            Assert.AreEqual(actors, result.Actors);

        }

    }
}
