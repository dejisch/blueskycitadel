using System;
using TechTalk.SpecFlow;

namespace Training8.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [When(@"I click on Login link")]
        public void WhenClickOnLoginLink()
        {
           ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am logged in to the site")]
        public void ThenIAmLoggedInToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
