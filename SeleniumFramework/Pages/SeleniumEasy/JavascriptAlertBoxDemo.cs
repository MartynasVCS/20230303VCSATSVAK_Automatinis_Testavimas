using System;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class JavascriptAlertBoxDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/javascript-alert-box-demo.html");
        }

        public static void ClickSimpleAlertButton()
        {
            string locator = "(//*[contains(@class,'panel-primary')])[1]//button";
            Common.Click(locator);
        }

        public static void ClickPromptAlertButton()
        {
            string locator = "(//*[contains(@class,'panel-primary')])[3]//button";
            Common.Click(locator);
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }

        public static void AcceptAlert()
        {
            Common.AcceptAlert();
        }

        public static bool CheckIfAlertIsActive()
        {
            return Common.CheckIfAlertIsActive();
        }

        public static void SendKeysToAlert(string keys)
        {
            Common.SendKeysToAlert(keys);
        }

        public static string GetPromptAlertOutputText()
        {
            string locator = "//*[@id='prompt-demo']";
            return Common.GetElementText(locator);
        }

        public static void DismissAlert()
        {
            Common.DismissAlert();
        }
    }
}
