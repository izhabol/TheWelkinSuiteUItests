using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        [Given(@"User is at the Login Window")]
        public void GivenUserIsAtTheLoginWindow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"User is logged in")]
        public void GivenUserIsLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
