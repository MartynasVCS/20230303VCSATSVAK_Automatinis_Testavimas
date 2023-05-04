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

        [Test]
        public void BasicFirstFormDemoTwoInputFields()
        {
            string valueA = "3";
            string valueB = "4";
            string expectedResult = "7";

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            IWebElement inputValueA = driver.FindElement(By.XPath("//*[@id=\"value1\"]"));
            inputValueA.SendKeys(valueA.ToString());

            IWebElement inputValueB = driver.FindElement(By.XPath("//*[@id=\"value2\"]"));
            inputValueB.SendKeys(valueB.ToString());

            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id=\"gettotal\"]//button"));
            buttonGetTotal.Click();

            IWebElement textValueTotal = driver.FindElement(By.XPath("//*[@id=\"displayvalue\"]"));
            string actualResult = textValueTotal.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }
    }
}
