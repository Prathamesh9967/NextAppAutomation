using NextApp.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NextApp.StepDefinitions
{
    [Binding]
    public class LoginSteps : DriverHelper
    {
        HomePage homepage = new HomePage();
        LoginPage loginpage = new LoginPage();

        [Given(@"I navigate to the WebApp")]
        public void GivenINavigateToTheWebApp()
        {
            driver.Navigate().GoToUrl(WebUrl);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Given(@"i click on login button")]
        public void GivenIClickOnLoginButton()
        {
            homepage.clickLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Given(@"I enter email and password")]
        public void GivenIEnterEmailAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.sendCredentials(data.email, data.password);
        }

        [Given(@"i click Submit button")]
        public void GivenIClickSubmitButton()
        {
            loginpage.clickSubmit();
        }


    }
}
