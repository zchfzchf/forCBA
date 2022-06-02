using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID19Game.Driver
{
    public class Browsers
    {
        public static IWebDriver webDriver;

        public static void Goto(string url)
        {
            webDriver.Url=url;
        }

        public static void InitDriver()
        {
            webDriver=new FirefoxDriver();
        }
        public static void Close()
        {
            webDriver.Quit();
        }

        public static string Title
            { get { return webDriver.Title; } }

    }
}
