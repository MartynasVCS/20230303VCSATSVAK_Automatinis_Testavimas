using NUnit.Framework;
using SeleniumFramework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            TextBox.Open();
        }

        [Test]
        public void FillFormWithValidInformation()
        {
            string name = "Martynas";
            string email = "email@email.com";
            string currentAddress = "Testas testas";
            string permanentAddress = "Labas labas";

            string expectedName = $"Name:{name}";
            string expectedEmail = $"Email:{email}";
            string expectedCurrentAddress = $"Current Address :{currentAddress}";
            string expectedPermanentAddress = $"Permananet Address :{permanentAddress}";

            TextBox.EnterFullName(name);
            TextBox.EnterEmail(email);
            TextBox.EnterCurrentAddress(currentAddress);
            TextBox.EnterPermanentAddress(permanentAddress);
            TextBox.ClickSubmitButton();

            string actualName = TextBox.GetName();
            string actualEmail = TextBox.GetEmail();
            string actualCurrentAddress = TextBox.GetCurrentAddress();
            string actualPermanentAddress = TextBox.GetPermanentAddress();

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedCurrentAddress, actualCurrentAddress);
            Assert.AreEqual(expectedPermanentAddress, actualPermanentAddress);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
