using System;
using TechTalk.SpecFlow;
using Training8.Utilities;

namespace Training8.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {

        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
           // ScenarioContext.Current.Pending();
        }


        [When(@"I am on the registration page")]
        public void WhenIAmOnTheRegistrationPage()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I fill the form")]
        public void WhenIFillTheForm()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I am registered")]
        public void ThenIAmRegistered()
        {
            //ScenarioContext.Current.Pending();
        }



        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.driver.Manage().Window.Maximize();
        }
        

        
        [Then(@"I am on the registration page")]
        public void ThenIAmOnTheRegistrationPage()
        {
           // ScenarioContext.Current.Pending();
        }



    }
}
