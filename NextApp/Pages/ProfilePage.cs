using OpenQA.Selenium;

namespace NextApp.Pages
{
    class ProfilePage : DriverHelper
    {
        IWebElement logoutBtn => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div[1]/button"));

        public void clickLogout() => logoutBtn.Click();
    }
}
