using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Szoftverteszt_beadando.pages;

namespace Szoftverteszt_beadando.tests
{
    [TestFixture]
    public class BaseTests
    {
        protected IWebDriver driver;
        protected Login_oldal login_Oldal;
        protected Fooldal fo_Oldal;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Login_oldal.URL);

            login_Oldal = new Login_oldal(driver);
            fo_Oldal = new Fooldal(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}