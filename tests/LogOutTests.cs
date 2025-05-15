using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szoftverteszt_beadando.pages;

namespace Szoftverteszt_beadando.tests
{
    [TestFixture]
    public class LogOutTests : BaseTests
    {
        [Test]
        public void CorrectLogOutHavetoReturnToLoginPage()
        {
            login_Oldal.LoggingIn("tesztuser", "titkos");
            fo_Oldal.Log_Out();
            Assert.AreEqual(Login_oldal.URL, driver.Url);
        }
    }
}
