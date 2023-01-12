using OpenQA.Selenium;

namespace NextApp.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement enterEmail => driver.FindElement(By.Name("email"));
        IWebElement enterPass => driver.FindElement(By.Name("password"));
        IWebElement submitBtn => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/form/div[3]/button[2]"));

        public void sendCredentials(string email , string password)
        {
            enterEmail.SendKeys(email);
            enterPass.SendKeys(password);
        }

        public void clickSubmit()
        {
            submitBtn.Click();
        }
    }
}
