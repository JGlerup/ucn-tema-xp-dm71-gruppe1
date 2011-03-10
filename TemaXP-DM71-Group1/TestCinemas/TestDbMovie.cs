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
        [TestMethod]
        public void TestInsert()
        {
            dbm = new DbMovie();
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
                Console.WriteLine("building movie object");
            }

            Assert.AreEqual(title, result.Title);
            Assert.AreEqual(actors, result.Actors);

        }
    }
}
