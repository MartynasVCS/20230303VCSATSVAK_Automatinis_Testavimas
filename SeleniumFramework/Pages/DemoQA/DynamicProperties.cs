using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/dynamic-properties");
        }

        public static bool WaitForFirstButtonToBeEnabled()
        {
            return Common.WaitForElementToBeEnabled(Locators.DynamicProperties.buttonFirst);
        }

        public static bool WaitForThirdButtonToBeVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.DynamicProperties.buttonThird);
        }
    }
}
