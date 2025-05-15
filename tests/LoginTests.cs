using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Szoftverteszt_beadando.pages;

namespace Szoftverteszt_beadando.tests
{
    [TestFixture]
    public class LoginTests : BaseTests
    {
        [Test]
        public void GoodUsernameandPassword_HavetoLoginCorrectly()
        {
            login_Oldal.LoggingIn("tesztuser", "titkos");
            Assert.AreEqual(Fooldal.URL,driver.Url);
        }

        [Test]
        public void BadPassword_HavetoThrowErrorMessage()
        {
            login_Oldal.LoggingIn("tesztuser", "skibidi");
            string errorUzenet = login_Oldal.GetError();
            Assert.AreEqual("Helytelen jelszó!", errorUzenet);
        }

        [Test]
        public void BadUsername_AlsoHavetoThrowErrorMessage()
        {
            login_Oldal.LoggingIn("sigma", "titkos");
            string error_Uzenet = login_Oldal.GetError();
            Assert.AreEqual("Nem létező felhasználó!", error_Uzenet);
        }

        [Test]
        public void EmptyFields_HavetoThrowErrorMessage()
        {
            login_Oldal.LoggingIn("", "");
            string error_Uzenet = login_Oldal.GetError();
            Assert.AreEqual("Hiányzó felhasználónév vagy jelszó!", error_Uzenet);
        }

    }
}
