using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace NextApp.Hooks
{
    [Binding]
    public sealed class Hooks1 : DriverHelper
    {

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}