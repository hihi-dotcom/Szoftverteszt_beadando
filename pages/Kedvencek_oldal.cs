using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Szoftverteszt_beadando.pages
{
    internal class Kedvencek_oldal : Base_oldal
    {
        public static readonly string URL = "http://127.0.0.1:5500/fefedezo_appocska/kedvencek.html";
        public Kedvencek_oldal(IWebDriver driver) : base(driver)
        {

        }

    }
}
