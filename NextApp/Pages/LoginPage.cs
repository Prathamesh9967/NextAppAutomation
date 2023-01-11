using OpenQA.Selenium;

namespace NextApp.Pages
{
    class LoginPage : DriverHelper
    {
        IWebElement enterEmail => driver.FindElement(By.Name("email"));
        IWebElement enterPass => driver.FindElement(By.Name("password"));
        IWebElement submitBtn => driver.FindElement(By.ClassName("form-btn"));

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
