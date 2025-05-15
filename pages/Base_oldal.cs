using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoftverteszt_beadando.pages
{
    public class Base_oldal
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        protected IWebElement LogoutLink => driver.FindElement(By.Id("logoutBtn"));

        public Base_oldal(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public void Log_Out()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(LogoutLink));
            LogoutLink.Click();
        }
    }
}
