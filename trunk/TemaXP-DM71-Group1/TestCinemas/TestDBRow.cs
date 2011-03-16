using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.ModelLayer;
using TemaXP_DM71_Group1.DBLayer;

namespace TestCinemas
{
    [TestClass]
    public class TestDBRow
    {

        private IFdbRow dbr;

        [TestMethod]
        public void TestInsert()
        {
            dbr = new DBRow();

            int id = 0;
            int rowNo = 3;
            List<int> seats = new List<int>();
            int noOfSeats = 5;
            Cinema cinema = new Cinema();
            int cId = 1;
            cinema.Id = cId;

            Row r = new Row();
            r.Id = id;
            r.RowNo = rowNo;
            r.NoOfSeats = noOfSeats;
            r.Cinema = cinema;
            

            Row result = new Row();
            try
            {
                dbr.InsertRow(r);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbr.FindRowByRowNoAndCinema(rowNo, cinema, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(rowNo, result.RowNo);
            Assert.AreEqual(noOfSeats, result.NoOfSeats);
            Assert.AreEqual(cinema.Id, result.Cinema.Id);

            MyTestCleanup(rowNo, cinema);

        }

        [TestMethod]
        public void TestFind()
        {
            dbr = new DBRow();

            int id = 0;
            int rowNo = 3;
            List<int> seats = new List<int>();
            int noOfSeats = 5;
            Cinema cinema = new Cinema();
            int cId = 1;
            cinema.Id = cId;

            Row r = new Row();
            r.Id = id;
            r.RowNo = rowNo;
            r.NoOfSeats = noOfSeats;
            r.Cinema = cinema;


            Row result = new Row();
            try
            {
                dbr.InsertRow(r);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbr.FindRowByRowNoAndCinema(rowNo, cinema, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(rowNo, result.RowNo);
            Assert.AreEqual(noOfSeats, result.NoOfSeats);
            Assert.AreEqual(cinema.Id, result.Cinema.Id);

            MyTestCleanup(rowNo, cinema);

        }

        [TestMethod]
        public void TestDelete()
        {
            dbr = new DBRow();

            int id = 0;
            int rowNo = 3;
            List<int> seats = new List<int>();
            int noOfSeats = 5;
            Cinema cinema = new Cinema();
            int cId = 1;
            cinema.Id = cId;

            Row r = new Row();
            r.Id = id;
            r.RowNo = rowNo;
            r.NoOfSeats = noOfSeats;
            r.Cinema = cinema;

            Row find = new Row();
            Row result = new Row();
            try
            {
                dbr.InsertRow(r);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                find = dbr.FindRowByRowNoAndCinema(rowNo, cinema, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbr.DeleteRow(find);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbr.FindRowByRowNoAndCinema(rowNo, cinema, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            Assert.AreEqual(0, result.RowNo);
            Assert.AreEqual(0, result.NoOfSeats);

            MyTestCleanup(rowNo, cinema);

        }

        private void MyTestCleanup(int rowNo, Cinema cinema)
        {
            Row row = new Row();
            try
            {
                row = dbr.FindRowByRowNoAndCinema(rowNo, cinema, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbr.DeleteRow(row);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }
        }
    }
}
