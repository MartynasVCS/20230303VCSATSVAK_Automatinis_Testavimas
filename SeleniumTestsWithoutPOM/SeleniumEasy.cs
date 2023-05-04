using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumTestsWithoutPOM
{
    internal class SeleniumEasy
    {
        [Test]
        public void BasicFirstFormDemoSingleInputField()
        {
            string expectedResult = "Martynas";

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='get-input']//*[@id='user-message']"));
            inputEnterMessage.SendKeys(expectedResult);
            
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']//button"));
            buttonShowMessage.Click();
            
            IWebElement textYourMessage = driver.FindElement(By.Id("display"));
            string actualResult = textYourMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }
    }
}
