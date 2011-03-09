using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.ControllerLayer;
using TemaXP_DM71_Group1.ModelLayer;


namespace TestMovies
{
    /// <summary>
    /// Summary description for TestCtrMovie
    /// </summary>
    [TestClass]
    public class TestCtrMovie
    {
        public TestCtrMovie()
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
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestInsertMovie()
        {
            string releaseDate = "010101";
            string title = "Djengis Kahn";
            string distributor = "egmont";
            string arrivalDate = "010101";
            string returnDate = "020202";
            string duration = "95 mins";
            string director = "Eva";
            string actors = "Himml";
            string movieDescription = "natur film";
            CtrMovie instance = new CtrMovie();
            try
            {
                instance.InsertMovie(releaseDate, title, distributor, arrivalDate, returnDate, duration, director, actors, movieDescription);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            Movie result = instance.FindMovie(title);
            Assert.AreEqual(result.ReleaseDate, releaseDate);
            Assert.AreEqual(result.Title, title);
            Assert.AreEqual(result.Distributor, distributor);
            Assert.AreEqual(result.ArrivalDate, arrivalDate);
            Assert.AreEqual(result.ReturnDate, returnDate);
            Assert.AreEqual(result.Duration, duration);
            Assert.AreEqual(result.Director, director);
            Assert.AreEqual(result.Actors, actors);
            Assert.AreEqual(result.MovieDescription, movieDescription);
        }

        [TestMethod]
        public void TestUpdatetMovie()
        {
            //Create
            string releaseDate = "010101";
            string title = "Djengis Kahn";
            string distributor = "egmont";
            string arrivalDate = "010101";
            string returnDate = "020202";
            string duration = "95 mins";
            string director = "Eva";
            string actors = "Himml";
            string movieDescription = "natur film";
            CtrMovie instance = new CtrMovie();
            try
            {
                instance.InsertMovie(releaseDate, title, distributor, arrivalDate, returnDate, duration, director, actors, movieDescription);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            //Update
            string currentTitle = title;
            string newReleaseDate = "040404";
            string newTitle = "John H";
            string newDistributor = "zentropa";
            string newArrivalDate = "080808";
            string newReturnDate = "101010";
            string newDuration = "65";
            string newDirector = "Solveig und Ilse";
            string newActors = "Strassen";
            string newMovieDescription = "filmfilm"
            try
            {
                instance.UpdateMovie(currentTitle, newReleaseDate, newTitle, newDistributor, newArrivalDate, newReturnDate, newDuration, newDirector, newActors, newMovieDescription);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }


            Movie result = instance.FindMovie(newTitle);
            Assert.AreEqual(result.ReleaseDate, newReleaseDate);
            Assert.AreEqual(result.Title, newTitle);
            Assert.AreEqual(result.Distributor, newDistributor);
            Assert.AreEqual(result.ArrivalDate, newArrivalDate);
            Assert.AreEqual(result.ReturnDate, newReturnDate);
            Assert.AreEqual(result.Duration, newDuration);
            Assert.AreEqual(result.Director, newDirector);
            Assert.AreEqual(result.Actors, newActors);
            Assert.AreEqual(result.MovieDescription, newMovieDescription);
        }

        [TestMethod]
        public void TestDeleteMovie()
        {
            string releaseDate = "010101";
            string title = "Djengis Kahn";
            string distributor = "egmont";
            string arrivalDate = "010101";
            string returnDate = "020202";
            string duration = "95 mins";
            string director = "Eva";
            string actors = "Himml";
            string movieDescription = "natur film";
            CtrMovie instance = new CtrMovie();
            try
            {
                instance.InsertMovie(releaseDate, title, distributor, arrivalDate, returnDate, duration, director, actors, movieDescription);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            instance.DeleteMovie(title);
        }
    }
}
