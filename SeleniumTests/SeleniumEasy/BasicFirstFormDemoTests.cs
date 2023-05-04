using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicFirstFormDemoTests
    {
        [Test]
        public void BasicFirstFormDemoSingleInputField()
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
    }
}
