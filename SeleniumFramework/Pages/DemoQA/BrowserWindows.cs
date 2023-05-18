using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages.DemoQA
{
    public class BrowserWindows
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/browser-windows");
        }

        public static void ClickNewTab()
        {

            string locator = "//*[@id='tabButton']";
            Common.Click(locator);
        }

        public static string GetNewTabHeading()
        {
            List<string> handles = Common.GetWindowHandles();
            Common.SwitchToWindowByHandle(handles.Last());

            string locator = "//*[@id='sampleHeading']";
            string headingText = Common.GetElementText(locator);

            Common.SwitchToWindowByHandle(handles.First());

            return headingText;
        }
    }
}
