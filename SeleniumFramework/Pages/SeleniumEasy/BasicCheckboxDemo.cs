using System;
using System.Collections.Generic;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void ClickAllCheckboxes()
        {
            string locator = "//*[@class='cb1-element']";
            Common.ClickElements(locator);
        }

        public static string GetButtonText()
        {
            string locator = "//*[@id='check1']";
            return Common.GetElementAttributeValue(locator, "value");
        }

        public static bool CheckIfAllCheckboxesAreChecked()
        {
            string locator = "//*[@class='cb1-element']";
            List<bool> statuses = Common.GetElementsCheckedStatusList(locator);

            foreach(bool status in statuses)
            {
                if (status == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
