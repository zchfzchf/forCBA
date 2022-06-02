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
    public class SignUp
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
        public IWebElement UserName()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#uname")));
        }

        public IWebElement Pwd()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#pwd")));
        }

        public IWebElement PwdRpt()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#psw-repeat")));
        }

        public IWebElement CancelBtn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#regomodal>div>div>div>button.cancelbtn")));
        }

        public IWebElement SignUpBtn()
        {
            return wait.Until(x => x.FindElement(By.CssSelector("#regomodal>div>div>div>button#signupbtn")));
        }



    }
}
