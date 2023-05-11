using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumFramework;

namespace SeleniumTests.DemoQA
{
    internal class SelectMenuTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            SelectMenu.Open();
        }

        [Test]
        public void SelectColorInStandardMenu()
        {
            string expectedColor = "Purple";

            SelectMenu.SelectColorInOldStyleMenu(expectedColor);
            string actualResult = SelectMenu.GetSelectedColorInOldStyleMenu();

            Assert.AreEqual(expectedColor, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
