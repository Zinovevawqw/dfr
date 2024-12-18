using MDK0101.AppData;
using MDK0101.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK0101Tests
{
    [TestClass()]
    public class AddSpravTests
    {
        [TestMethod()]
        public void CheckInformationNazvanRabotTest()
        {
            Sprav spr = new Sprav { NazvanRabot = "Ремонт", VidRabot = "Капитальные", Price = 3 };
            bool expected = true;
            bool actual = AddSprav.CheckInformation(spr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckInformationVidRabotTest()
        {
            Sprav inf = new Sprav { NazvanRabot = "Ремонт", VidRabot = "", Price = 0 };
            bool expected = false;
            bool actual = AddSprav.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckInformationPriceTest()
        {
            Sprav inf = new Sprav { NazvanRabot = "Ремонт", VidRabot = "", Price = 0 };
            bool expected = false;
            bool actual = AddSprav.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
    }
}
