using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using COVID19Game.Driver;
using System.Threading;

namespace COVID19Game.PageObject
{
    public class HomePage
    {
        static string Url = "https://responsivefight.herokuapp.com/";
        WebDriverWait wait = new WebDriverWait(Browsers.webDriver, new TimeSpan(0, 0, 5));

        public void Goto()
        {
            Browsers.Goto(Url);
        }

        public void Click_Btn(IWebElement el)
        {
            el.Click();
        }
        public IWebElement RegisterBtn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#rego")));
        }

        public IWebElement Login_Btn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#login")));
        }

    }
}
