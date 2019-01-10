using System;
using TechTalk.SpecFlow;
using Training8.PageObjects;
using Training8.Utilities;

namespace Training8.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;


        public LoginSteps()
        {
            loginPage = new LoginPage();
        }

        [When(@"I click on Login link")]
        public void WhenClickOnLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            loginPage.TypeEmail();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            loginPage.TypePassword();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginPage.ClickSignin();
        }
        
        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
