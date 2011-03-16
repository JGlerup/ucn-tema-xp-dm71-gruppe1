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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for DBCinema Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void DBCinemaConstructorTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DeleteCinema
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void DeleteCinemaTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor(); // TODO: Initialize to an appropriate value
            Cinema c = null; // TODO: Initialize to an appropriate value
            target.DeleteCinema(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FindAllShows
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void FindAllShowsTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor(); // TODO: Initialize to an appropriate value
            bool retrieveAssociation = false; // TODO: Initialize to an appropriate value
            IList<Cinema> expected = null; // TODO: Initialize to an appropriate value
            IList<Cinema> actual;
            actual = target.FindAllShows(retrieveAssociation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindCinemaByNoOfCinema
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void FindCinemaByNoOfCinemaTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor(); // TODO: Initialize to an appropriate value
            int noOfCinema = 0; // TODO: Initialize to an appropriate value
            bool retrieveAssociation = false; // TODO: Initialize to an appropriate value
            Cinema expected = null; // TODO: Initialize to an appropriate value
            Cinema actual;
            actual = target.FindCinemaByNoOfCinema(noOfCinema, retrieveAssociation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindCinemaByShowID
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void FindCinemaByShowIDTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor(); // TODO: Initialize to an appropriate value
            Show s = null; // TODO: Initialize to an appropriate value
            bool retrieveAssociation = false; // TODO: Initialize to an appropriate value
            Cinema expected = null; // TODO: Initialize to an appropriate value
            Cinema actual;
            actual = target.FindCinemaByShowID(s, retrieveAssociation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertCinema
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void InsertCinemaTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor(); // TODO: Initialize to an appropriate value
            Cinema c = null; // TODO: Initialize to an appropriate value
            target.InsertCinema(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UpdateCinema
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemaXP-DM71-Group1.exe")]
        public void UpdateCinemaTest()
        {
            DBCinema_Accessor target = new DBCinema_Accessor(); // TODO: Initialize to an appropriate value
            Cinema c = null; // TODO: Initialize to an appropriate value
            target.UpdateCinema(c);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
