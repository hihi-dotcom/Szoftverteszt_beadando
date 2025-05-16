using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szoftverteszt_beadando.pages
{
    public class Beallitasok_oldal : Base_oldal
    {
        public static readonly string URL = "http://127.0.0.1:5500/fefedezo_appocska/beallitasok.html";
        public Beallitasok_oldal(IWebDriver driver) : base(driver)
        {

        }
    }
}
