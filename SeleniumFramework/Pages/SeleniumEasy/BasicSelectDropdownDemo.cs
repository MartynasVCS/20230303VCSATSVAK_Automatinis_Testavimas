using System;
using System.Collections.Generic;

namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicSelectDropdownDemo
    {
        public static void Open()
        {
            Driver.OpenPage("https://demo.seleniumeasy.com/basic-select-dropdown-demo.html");
        }

        public static bool CheckIfActualValuesContainAllOfTheExpectedValues(List<string> expectedValues)
        {
            string locator = "//*[@id='select-demo']/option[not(@disabled)]";
            List<string> actualValues = Common.GetElementsTextList(locator);

            foreach (string value in expectedValues)
            {
                if (!actualValues.Contains(value))
                {
                    throw new Exception($"The value '{value}' is not present in expected values!!!");
                }
            }

            return true;
        }
    }
}
