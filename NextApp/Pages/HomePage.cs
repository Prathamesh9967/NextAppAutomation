using OpenQA.Selenium;

namespace NextApp.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement loginBtn => driver.FindElement(By.ClassName("my-btn"));
        IWebElement profileBtn => driver.FindElement(By.LinkText("PROFILE"));

        public void clickLogin() => loginBtn.Click();
        public void clickProfile() => profileBtn.Click();
        public bool profileBtnExists() => profileBtn.Displayed;
    }
}
