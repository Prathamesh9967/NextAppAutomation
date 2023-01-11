using OpenQA.Selenium;

namespace NextApp.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement loginBtn => driver.FindElement(By.ClassName("my-btn"));

        public void clickLogin() => loginBtn.Click();
    }
}
