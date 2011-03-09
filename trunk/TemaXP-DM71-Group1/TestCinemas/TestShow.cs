using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.ModelLayer;

namespace TestCinemas
{
    [TestClass]
    public class TestShow
    {
        [TestMethod]
        public void TestMethod1()
        {
            Show s = new Show();
            Cinema c = new Cinema("y", 75);
            s.Cinema = c;
            s.Date = "120511";
            Movie m = new Movie();
            m.Title = "Die Hard";
            m.ReleaseDate = "121212";
            m.Distributor = "Nordisk Film";
            m.ArrivalDate = "121211";
            m.ReturnDate = "241211";
            m.Duration = "1t 20m";
            m.Director = "Erik G";
            m.Actors = "Gunner aka Gundhild";
            m.MovieDescription = "Hårdtslående gunner er tilbage i storform. Denne gang slår gunner aka GUNhild sig paa flasken og giver den hele armen";
            s.Movie = m;
            s.Time = "00:30";
            Assert.AreEqual(s.Cinema, c);
            Assert.AreEqual(s.Date, "120511");
            Assert.AreEqual(s.Movie, m);
            Assert.AreEqual(s.Time, "00:30");
        }
    }
}
