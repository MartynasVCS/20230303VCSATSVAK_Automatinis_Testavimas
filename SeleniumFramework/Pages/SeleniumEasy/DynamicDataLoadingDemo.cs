using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class DynamicDataLoadingDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        public static void ClickGetNewUserButton()
        {
            string locatorButton = "//*[@id='save']";
            string locatorUserInformation = "//*[@id='loading']";

            Common.Click(locatorButton);
            Common.WaitForElementToNotContainText(locatorUserInformation, "loading...");
        }

        public static string GetUserInformation()
        {
            string locator = "//*[@id='loading']";
            return Common.GetElementText(locator);
        }
    }
}
