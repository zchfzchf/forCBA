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
    public class LoginPage
    {
        WebDriverWait wait = new WebDriverWait(Browsers.webDriver, new TimeSpan(0, 0, 5));

        public void Click_Btn(IWebElement el)
        {
            el.Click();
        }
        public void Enter_Txt(IWebElement el, string txt)
        {
            el.SendKeys(txt);
        }
        public IWebElement Login_Title()

        {
            return wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#loginmodal>div>div>h1")));
            //return wait.Until(x => x.FindElement(By.CssSelector("#login_title")));
        }

        public IWebElement Login_UName()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal input[id='worrior_username']")));
        }

        public IWebElement Login_Pwd()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal input[id='worrior_pwd']")));
        }
        public IWebElement Login_Btn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal a[id='warrior']")));
        }
        public IWebElement Login_Cancel_Btn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#loginmodal a[id='close']")));
        }
    }
}
