using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicCheckboxDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicCheckboxDemo.Open();
        }

        [Test]
        public void ClickMultipleCheckboxes()
        {
            string expectedValue = "Uncheck All";

            BasicCheckboxDemo.ClickAllCheckboxes();
            bool allCheckboxesAreChecked = BasicCheckboxDemo.CheckIfAllCheckboxesAreChecked();
            string actualValue = BasicCheckboxDemo.GetButtonText();

            Assert.AreEqual(expectedValue, actualValue);
            Assert.IsTrue(allCheckboxesAreChecked);
        }
    }
}
