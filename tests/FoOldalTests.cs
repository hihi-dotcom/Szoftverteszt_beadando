using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using Szoftverteszt_beadando.pages;

namespace Szoftverteszt_beadando.tests
{
    [TestFixture]
    internal class FoOldalTests : BaseTests
    {
        [SetUp]
        public void Setup()
        {
            login_Oldal.LoggingIn("tesztuser", "titkos");
        }

        [Test]
        public void TermekekListajaDisplayedCorrectly()
        {
            Assert.AreEqual(6, fo_Oldal.GetTermekSzama());
        }

        [Test]
        public void BeallitasokGombNavigatesToSettingsPerfectly()
        {
            fo_Oldal.GoToBeallitasok();
            Assert.AreEqual(Beallitasok_oldal.URL, driver.Url);
        }
        [Test]
        public void KedvencekGombNavigatesToKedvencekPerfectly()
        {
            fo_Oldal.GoToKedvencek();
            Assert.AreEqual(Kedvencek_oldal.URL, driver.Url);
        }

        [Test]
        public void TermekekDissappearCorrectly()
        {
            fo_Oldal.ShowOrNotShowTermekek();
            Assert.False(fo_Oldal.LatszanakeaTermekek());
        }

        [Test]
        public void TermekekAppearCorrectly() 
        {
            if(fo_Oldal.LatszanakeaTermekek() == false)
            {
                fo_Oldal.ShowOrNotShowTermekek();
            }
        }

        [Test]
        public void IsTermekAddedtoSettingsandAlertShows()
        {
            fo_Oldal.AddTermekToBeallitasok(2);
            Assert.True(fo_Oldal.IsTermekAddedtoBeallitasokAlertShows());

        }

        [Test]
        public void IsTermekAddedtoKedvencekandAlertShows()
        {
            fo_Oldal.AddTermekToKedvencek(4);
            Assert.True(fo_Oldal.IsTermekAddedtoKedvencekAlertShows());
        }
    }
}
