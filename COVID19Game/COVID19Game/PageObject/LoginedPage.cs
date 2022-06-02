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
    public class LoginedPage
    {
        WebDriverWait wait = new WebDriverWait(Browsers.webDriver, new TimeSpan(0, 0, 5));
        public void Click_Btn(IWebElement el)
        {
            el.Click();
        }
        public IWebElement Title()
        {
         
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal>div>div>h1")));
        }

        public IWebElement UserName()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal>div>div>h3")));

        }

        public IWebElement StartGame_Btn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal>div>div>a#start")));
        }


    }
}
