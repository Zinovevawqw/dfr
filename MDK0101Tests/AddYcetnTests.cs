using Microsoft.VisualStudio.TestTools.UnitTesting;
using MDK0101.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDK0101.AppData;

namespace MDK0101.Pages.Tests
{
    [TestClass()]
    public class AddYcetnTests
    {
        [TestMethod()]
        public void CheckAccountingDataNacalaTest()
        {
            Ycetn acc = new Ycetn { DlitelnostRabot = -2, DataNacala = DateTime.Now, Kol_voVipoln = 2 };
            bool expected = true;
            bool actual = AddYcetn.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckNullAccountingDataNacalaTest()
        {
            Ycetn acc = new Ycetn { DlitelnostRabot = 2, DataNacala = DateTime.Now, Kol_voVipoln = 5 };
            bool expected = true;
            bool actual = AddYcetn.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckDigitAccountingKol_voVipolnTest()
        {
            Ycetn acc = new Ycetn { DlitelnostRabot = 2, DataNacala = DateTime.Now, Kol_voVipoln = -2 };
            bool expected = true;
            bool actual = AddYcetn.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
    }
}