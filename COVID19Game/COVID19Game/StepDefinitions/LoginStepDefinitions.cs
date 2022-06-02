using System;
using TechTalk.SpecFlow;
using COVID19Game.Driver;
using NUnit.Framework;

namespace COVID19Game.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"I click the Login button")]
        public void GivenIClickTheLoginButton()
        {
            Pages.Homepage.Click_Btn(Pages.Homepage.Login_Btn());
        }


        [When(@"I enter the ""([^""]*)"" on Login")]
        public void WhenIEnterTheOnLogin(string username)
        {
            Pages.Loginpage.Enter_Txt(Pages.Loginpage.Login_UName(),username);
        }

        [When(@"I also enter the ""([^""]*)"" on Login")]
        public void WhenIAlsoEnterTheOnLogin(string password)
        {
            Pages.Loginpage.Enter_Txt(Pages.Loginpage.Login_Pwd(), password);
        }

        [When(@"I click Login warrior button")]
        public void WhenIClickLoginWarriorButton()
        {
            Pages.Loginpage.Click_Btn(Pages.Loginpage.Login_Btn());
            Thread.Sleep(3000);
        }

        [Then(@"I can start the game")]
        public void ThenICanStartTheGame()
        {

            string title=Pages.Loginedpage.Title().Text;
            Assert.AreEqual(title, "Welcome to the game");
            
        }
    }
}
