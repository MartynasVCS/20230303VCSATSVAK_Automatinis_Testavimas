using OpenQA.Selenium;
using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/basic-first-form-demo.html");
        }

        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='get-input']//*[@id='user-message']";
            Common.SendKeys(locator, message);
        }

        public static void ClickShowMessage()
        {
            string locator = "//*[@id='get-input']//button";
            Common.Click(locator);
        }

        public static string GetYourMessage()
        {
            string locator = "//*[@id='display']";
            return Common.GetElementText(locator);
        }

        public static void EnterValueA(string valueA)
        {
            string locator = "//*[@id='value1']";
            Common.SendKeys(locator, valueA);
        }

        public static void EnterValueB(string valueB)
        {
            string locator = "//*[@id='value2']";
            Common.SendKeys(locator, valueB);
        }

        public static void ClickGetTotal()
        {
            string locator = "//*[@id='gettotal']//button";
            Common.Click(locator);
        }

        public static string GetTotal()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.GetElementText(locator);
        }
    }
}
