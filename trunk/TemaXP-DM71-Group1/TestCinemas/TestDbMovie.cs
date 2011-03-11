﻿using System;
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
            
            String releaseDate = "1809-09-09";
            String title = "Sjov";
            String distributor = "xx";
            String arr = "1809-09-09";
            String ret = "1809-09-09";
            String dur = "01:01:01";
            String dir = "xx";
            String actors = "Krbyr";
            String moDis = "xx";
            
            Movie nm = new Movie();
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

        [TestMethod]
        public void TestDeleteMovie()
        {
            dbm = new DbMovie();
            
            String releaseDate = "2009.09.09";
            String title = "Test";
            String distributor = "xx";
            String arr = "2009.09.09";
            String ret = "2009.09.09";
            String dur = "01:01:01";
            String dir = "xx";
            String actors = "Krbyr";
            String moDis = "xx";
            Movie nm = new Movie();
            
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
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbm.DeleteMovie(nm);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbm.FindMovie(title);
            }
            catch (Exception e)
            {

                Assert.Fail(e.Message);
            }

         }

        [TestMethod]
        public void TestUpdateMovie()
        {
            dbm = new DbMovie();
            
            String releaseDate = "1909-09-09";
            String title = "Tester";
            String distributor = "xx";
            String arr = "1909-09-09";
            String ret = "1909-09-09";
            String dur = "01:01:01";
            String dir = "xx";
            String actors = "Krbyr-dyret";
            String moDis = "xx";
            String newTitle = "UpdatedTester";
            Movie nm = new Movie();
            Movie mID = new Movie();
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
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                mID = dbm.FindMovie(title);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            mID.Title = newTitle;
            try
            {
                dbm.UpdateMovie(mID);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbm.FindMovie(newTitle);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(mID.Id, result.Id);
            Assert.AreEqual(releaseDate, result.ReleaseDate);
            Assert.AreEqual(newTitle, result.Title);
            Assert.AreEqual(distributor, result.Distributor);
            Assert.AreEqual(arr, result.ArrivalDate);
            Assert.AreEqual(ret, result.ReturnDate);
            Assert.AreEqual(dur, result.Duration);
            Console.WriteLine("Duration : " + result.Duration);
            Assert.AreEqual(dir, result.Director);
            Assert.AreEqual(actors, result.Actors);
            Assert.AreEqual(moDis, result.MovieDescription);

        }



    }
}
