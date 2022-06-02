using System;
using TechTalk.SpecFlow;
using COVID19Game.Driver;
using NUnit.Framework;
using System.Threading;

namespace COVID19Game.StepDefinitions
{
    [Binding]
    public class SignUpStepDefinitions
    {
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            Pages.Homepage.Goto();
        }

        [Given(@"I click the Register button")]
        public void GivenIClickTheRegisterButton()
        {
            Pages.Homepage.Click_Btn(Pages.Homepage.RegisterBtn());
        }


        [When(@"I enter the ""([^""]*)""")]
        public void WhenIEnterThe(string username)
        {
            Pages.Signup.Enter_Txt(Pages.Signup.UserName(),username);
        }

        [When(@"I also enter the ""([^""]*)""")]
        public void WhenIAlsoEnterThe(string password)
        {
            Pages.Signup.Enter_Txt(Pages.Signup.Pwd(),password);
        }

        [When(@"I repeat ""([^""]*)""")]
        public void WhenIRepeat(string rp_password)
        {
            Pages.Signup.Enter_Txt(Pages.Signup.PwdRpt(), rp_password);
        }

        [When(@"I click Sign Up button")]
        public void WhenIClickSignUpButton()
        {
            Pages.Signup.Click_Btn(Pages.Signup.SignUpBtn());
   
        }

        [Then(@"I sign up successfully to see the Login prompt")]
        public void ThenISignUpSuccessfullyToSeeTheLoginPrompt()
        {

            bool Title_Displayed = Pages.Loginpage.Login_Title().Displayed;

            Assert.AreEqual(true,Title_Displayed);

       

        }
    }
}
