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
        public Fooldal(IWebDriver driver) : base(driver)
        {
            
        }
    }
}
