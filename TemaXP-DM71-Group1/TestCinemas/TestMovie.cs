using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.ModelLayer;

namespace TestCinemas
{
    /// <summary>
    /// Summary description for Movie
    /// </summary>
    [TestClass]
    public class TestMovie
    {
        public TestMovie()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup() 
        {
            
        }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            Movie m = new Movie();
            m.Title = "Die Hard";
            m.ReleaseDate =  "121212";
            m.Distributor = "Nordisk Film";
            m.ArrivalDate = "121211";
            m.ReturnDate = "241211";
            m.Duration = "1t 20m";
            m.Director = "Erik G";
            m.Actors = "Gunner aka Gundhild";
            m.MovieDescription = "Hårdtslående gunner er tilbage i storform. Denne gang slår gunner aka GUNhild sig paa flasken og giver den hele armen";

            Assert.AreEqual(m.Title, "Die Hard");
            Assert.AreEqual(m.ReleaseDate, "121212");
            Assert.AreEqual(m.Distributor, "Nordisk Film");
            Assert.AreEqual(m.ArrivalDate, "121211");
            Assert.AreEqual(m.ReturnDate, "241211");
            Assert.AreEqual(m.Duration, "1t 20m");
            Assert.AreEqual(m.Director, "Erik G");
            Assert.AreEqual(m.Actors, "Gunner aka Gundhild");
            Assert.AreEqual(m.MovieDescription, "Hårdtslående gunner er tilbage i storform. Denne gang slår gunner aka GUNhild sig paa flasken og giver den hele armen");



        }

    }
}
