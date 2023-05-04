using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    internal class Driver
    {
        private static IWebDriver driver;

        internal static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }

        internal static void OpenPage(string url)
        {
            driver.Url = url;
        }

        internal static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}
