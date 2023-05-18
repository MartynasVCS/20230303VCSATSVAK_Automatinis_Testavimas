using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class Frames
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/frames");
        }
        public static string GetHeadingText()
        {
            string iframeLocator = "//*[@id='frame1']";
            Common.SwitchToIframeByLocator(iframeLocator);

            string headingLocator = "//*[@id='sampleHeading']";
            string headingText = Common.GetElementText(headingLocator);

            Common.SwitchToDefaultContent();

            return headingText;
        }
    }
}
