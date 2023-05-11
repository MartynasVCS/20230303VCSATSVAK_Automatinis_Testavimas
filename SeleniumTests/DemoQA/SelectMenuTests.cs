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
        public void SelectColorInOldStyleMenu()
        {
            string expectedColor = "Purple";

            SelectMenu.SelectColorInOldStyleMenu(expectedColor);
            string actualResult = SelectMenu.GetSelectedColorInOldStyleMenu();

            Assert.AreEqual(expectedColor, actualResult);
        }

        [Test]
        public void SelectTitleInSelectOneMenu()
        {
            string expectedTitle = "Prof.";

            SelectMenu.SelectTitleInSelectOneMenu(expectedTitle);
            string actualTitle = SelectMenu.GetSelectedTitleInSelectOneMenu();

            StringAssert.Contains(expectedTitle, actualTitle);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
