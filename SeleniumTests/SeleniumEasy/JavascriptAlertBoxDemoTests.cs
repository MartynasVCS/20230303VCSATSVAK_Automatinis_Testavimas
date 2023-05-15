using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;

namespace SeleniumTests.SeleniumEasy
{
    internal class JavascriptAlertBoxDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            JavascriptAlertBoxDemo.Open();
        }

        [Test]
        public void SimpleAlert()
        {
            string expectedText = "I am an alert box!";

            JavascriptAlertBoxDemo.ClickSimpleAlertButton();
            string actualText = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.AcceptAlert();

            Assert.AreEqual(expectedText, actualText);
            Assert.IsFalse(JavascriptAlertBoxDemo.CheckIfAlertIsActive());
        }

        [Test]
        public void PromptAlertWithSendKeys()
        {
            string expectedText = "Sveiki gyvi!";

            JavascriptAlertBoxDemo.ClickPromptAlertButton();
            JavascriptAlertBoxDemo.SendKeysToAlert(expectedText);
            JavascriptAlertBoxDemo.AcceptAlert();
            string actualText = JavascriptAlertBoxDemo.GetPromptAlertOutputText();

            StringAssert.Contains(expectedText, actualText);
            Assert.IsFalse(JavascriptAlertBoxDemo.CheckIfAlertIsActive());
        }

        [Test]
        public void PromptAlertWithoutSendKeys()
        {
            string expectedText = string.Empty;

            JavascriptAlertBoxDemo.ClickPromptAlertButton();
            JavascriptAlertBoxDemo.DismissAlert();
            string actualText = JavascriptAlertBoxDemo.GetPromptAlertOutputText();

            Assert.AreEqual(expectedText, actualText);
            Assert.IsFalse(JavascriptAlertBoxDemo.CheckIfAlertIsActive());
        }
    }
}
