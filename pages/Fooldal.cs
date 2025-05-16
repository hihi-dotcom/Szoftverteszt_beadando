using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace Szoftverteszt_beadando.pages
{
    public class Fooldal : Base_oldal
    {
        public static readonly string URL = "http://127.0.0.1:5500/fefedezo_appocska/fooldal.html";
        ReadOnlyCollection<IWebElement> termekek => driver.FindElements(By.ClassName("termek-kartya"));
        ReadOnlyCollection<IWebElement> termekarak => driver.FindElements(By.ClassName("termek-ar"));
        ReadOnlyCollection<IWebElement> termeknevek => driver.FindElements(By.ClassName("termek-nev"));
        ReadOnlyCollection<IWebElement> addButtons => driver.FindElements(By.Id("hozzaadas"));
        ReadOnlyCollection<IWebElement> kedvencekButtons => driver.FindElements(By.Id("kedvencek"));
        IWebElement TermekekListazva => driver.FindElement(By.Id("termekLista"));
        IWebElement BeallitasoldalGomb => driver.FindElement(By.Id("beallitasok"));
        IWebElement KedvencekOldalGomb => driver.FindElement(By.Id("tokedvenc"));
        IWebElement EltuntetesGomb => driver.FindElement(By.Id("toggleTermekek"));
        IWebElement Alert => driver.FindElement(By.ClassName("alert"));
        public Fooldal(IWebDriver driver) : base(driver)
        {

        }

        public int GetTermekSzama()
        {
            return termekek.Count;
        }

        public bool LatszanakeaTermekek()
        {
            try
            {
                return TermekekListazva.Displayed;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        public void AddTermekToBeallitasok(int index)
        {
            if (index < addButtons.Count)
            {
                addButtons[index].Click();
            }
        }

        public void AddTermekToKedvencek(int index)
        {
            if (index < kedvencekButtons.Count)
            {
                kedvencekButtons[index].Click();
            }
        }

        public void GoToBeallitasok()
        {
            BeallitasoldalGomb.Click();
        }
        public void GoToKedvencek()
        {
            KedvencekOldalGomb.Click();
        }

        public void ShowOrNotShowTermekek()
        {
            EltuntetesGomb.Click();
        }

        public bool IsTermekAddedtoBeallitasokAlertShows()
        {
            try
            {

                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {

                return false;
            }
        }

        public bool IsTermekAddedtoKedvencekAlertShows()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
    }
}
