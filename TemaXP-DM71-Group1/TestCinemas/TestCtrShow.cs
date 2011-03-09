using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCinemas
{
    [TestClass]
    public class TestCtrShowC//:@"C:\\Users\Glerup\Documents\Skole\Projekter\Tema XP\TemaXP-DM71-Group1\TestCinemas\TestCtrShow.cs"
    {
        [TestMethod]
        public void TestMethod1()
        {
            CtrShow cs = new CtrShow();
            Console.WriteLine("tester vi kan indsætte data");
            String time = "16:00:00";
            String date = "2011-02-03";
            String playTime = "01:30:00.0";
            int cinema = 2;
            String title = "KickAss";
            cs.insertShow(time, date, playTime, cinema, title);
            Assert.AreEqual(title, cs.findShowByID(0).getTitle());
            String title = "Haha";
            cs.updateShow(0, time, date, playTime, cinema, title);
            Assert.AreEqual(title, cs.findShowByID(0).getTitle());
            cs.deleteShow(0);
            Assert.AreEqual(null, cs.getAllShows());
        }
    }
}
