using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicFirstFormDemoTests
    {
        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Labas";

            Driver.InitializeDriver();
            BasicFirstFormDemo.Open();

            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessage();
            string actualResult = BasicFirstFormDemo.GetYourMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.ShutdownDriver();
        }

        [Test]
        public void TwoInputFields()
        {
            string valueA = "3";
            string valueB = "4";
            string expectedResult = "7";

            Driver.InitializeDriver();
            BasicFirstFormDemo.Open();

            BasicFirstFormDemo.EnterValueA(valueA);
            BasicFirstFormDemo.EnterValueB(valueB);
            BasicFirstFormDemo.ClickGetTotal();
            string actualResult = BasicFirstFormDemo.GetTotal();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.ShutdownDriver();
        }
    }
}
