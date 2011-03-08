using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemaXP_DM71_Group1.ModelLayer;

namespace TestCinemas
{
    [TestClass]
    public class TestCinemas
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cinemas c = new Cinemas();
            Console.WriteLine("tester vi kan indsætte data");
            String name = "gunner";
            int seats = 45;
            c.Name = name;
            c.NrOfSeats = seats;
            Assert.AreEqual(name, c.Name);
            Assert.AreEqual(seats, c.NrOfSeats);
        }
    }
}
