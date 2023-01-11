using OpenQA.Selenium;

namespace NextApp
{
    public class DriverHelper
    {
        public static IWebDriver driver { get; set; }

        public string WebUrl = "https://next-fire-auth.vercel.app/";
    }
}
