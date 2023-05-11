using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumFramework;

namespace SeleniumTests.DemoQA
{
    internal class ButtonsTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Buttons.Open();
        }

        [Test]
        public void DoubleClick()
        {
            string expectedResult = "You have done a double click";

            Buttons.DoubleClickFirstButton();
            string actualResult = Buttons.GetDoubleClickActionOutput();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RightClick()
        {
            string expectedResult = "You have done a right click";

            Buttons.RightClickSecondButton();
            string actualResult = Buttons.GetRightClickActionOutput();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void LeftClick()
        {
            string expectedResult = "You have done a dynamic click";

            Buttons.LeftClickThirdButton();
            string actualResult = Buttons.GetLeftClickActionOutput();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
