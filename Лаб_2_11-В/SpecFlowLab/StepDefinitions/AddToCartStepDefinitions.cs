using PagesLab2_Pages;
using TechTalk.SpecFlow;


namespace SpecFlowLab_2.StepDefinitions
{
    [Binding]
    public class StepDefinitions : BaseSteps
    {
        private LoginPage loginPage;

        [Given(@"swaglabs page")]
        public void GivenSwaglabsPage()
        {
            driver.Url = "https://www.saucedemo.com";
            loginPage = new LoginPage(driver);
        }

        [When(@"user logined")]
        public void WhenUserLogined()
        {
            loginPage.LoginWithNameAndPassword();
        }

        [Then(@"check if user is locked out")]
        public void ThenCheckIfSelectedProductWasAdded()
        {
            loginPage.CheckThatUserIsLockedOut();
        }
    }
}