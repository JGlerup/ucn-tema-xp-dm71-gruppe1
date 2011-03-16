using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.ModelLayer;

namespace TestCinemas
{
    [TestClass]
    public class TestDBRow
    {

        private IFDBRow dbr;

        [TestMethod]
        public void TestInsert()
        {
            dbr = new DBRow();

            int id = 0;
            int rowNo = 3;
            List<int> seats = new List<int>();
            int noOfSeats = 5;
            Cinema c = new Cinema();
            int cId = 1;
            c.Id = cId;

            Row r = new Row();
            r.Id = id;
            r.RowNo = rowNo;
            r.NoOfSeats = noOfSeats;
            r.C = c;
           

            Row result = new Row();
            try
            {
                dbr.InserRow(r);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                result = dbr.FindRowByRowNoAndCinema(rowNo, c, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }


            Assert.AreEqual(rowNo, result.RowNo);
            Assert.AreEqual(noOfSeats, result.NoOfSeats);
            Assert.AreEqual(c.Id, result.C.Id);
            Assert.AreEqual(arr, result.ArrivalDate);
            Assert.AreEqual(ret, result.ReturnDate);
            Assert.AreEqual(dur, result.Duration);
            Assert.AreEqual(dir, result.Director);
            Assert.AreEqual(actors, result.Actors);
            Assert.AreEqual(moDis, result.MovieDescription);

            MyTestCleanup(title);

        }

        private void MyTestCleanup(string t)
        {
            Movie m = new Movie();
            try
            {
                m = dbm.FindMovieByTitle(t, false);
            }
            catch (Exception e)
            {

                Console.WriteLine("virker ikke " + e.Message);
            }

            try
            {
                dbm.DeleteMovie(m);
            }
            catch (Exception e)
            {
                Console.WriteLine("virker ikke " + e.Message);
            }
        }
    }
}
