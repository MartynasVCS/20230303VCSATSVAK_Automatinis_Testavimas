using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class BrowserWindowsTests : BaseTest
    {
        [Test]
        public void Demo()
        {
            string expectedResult = "This is a sample page";

            BrowserWindows.Open();
            BrowserWindows.ClickNewTab();
            string actualResult = BrowserWindows.GetNewTabHeading();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
