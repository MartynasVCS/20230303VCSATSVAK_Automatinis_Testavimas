using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicFirstFormDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicFirstFormDemo.Open();
        }

        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Labas";

            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessage();
            string actualResult = BasicFirstFormDemo.GetYourMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TwoInputFields()
        {
            string valueA = "3";
            string valueB = "4";
            string expectedResult = "7";

            BasicFirstFormDemo.EnterValueA(valueA);
            BasicFirstFormDemo.EnterValueB(valueB);
            BasicFirstFormDemo.ClickGetTotal();
            string actualResult = BasicFirstFormDemo.GetTotal();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
