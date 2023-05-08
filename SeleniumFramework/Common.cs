using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollUntilElementIsClickable(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 20;
            int currentTry = 0;

            while(!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch(Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 200)");
                        currentTry++;
                    } 
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

        internal static string GetElementCssAttributeValue(string locator, string attribute)
        {
             return GetElement(locator).GetCssValue(attribute);
        }

        internal static void WaitForElementCssAttributeValueToBe(string locator, string attributeName, string expectedAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(2));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);   
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetCssValue(attributeName).Equals(expectedAttributeValue));
        }
    }
}
