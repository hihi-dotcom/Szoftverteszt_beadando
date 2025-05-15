using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Szoftverteszt_beadando.pages
{
    public class Login_oldal : Base_oldal
    {
        public static readonly string URL = "http://127.0.0.1:5500/fefedezo_appocska/index.html";

        IWebElement usernameMezo => driver.FindElement(By.Id("username"));
        IWebElement passwordMezo => driver.FindElement(By.Id("password"));
        IWebElement bejelGomb => driver.FindElement(By.Id("loginBtn"));
        IWebElement HibaMessage => driver.FindElement(By.Id("error-message"));
        public Login_oldal(IWebDriver driver) : base(driver)
        {

        }

        public void LoggingIn(string felhnev, string jelszo) 
        {
            usernameMezo.SendKeys(felhnev);
            passwordMezo.SendKeys(jelszo);
            bejelGomb.Click();
        }

        public string GetError()
        {
            return HibaMessage.Text;
        }
    }
}
