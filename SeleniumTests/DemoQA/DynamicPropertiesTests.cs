using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumFramework;

namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicProperties.Open();
        }

        [Test]
        public void WaitForButtonToBeEnabled()
        {
            Assert.IsTrue(DynamicProperties.WaitForFirstButtonToBeEnabled());
        }

        [Test]
        public void WaitForButtonToBeVisible()
        {
            Assert.IsTrue(DynamicProperties.WaitForThirdButtonToBeVisible());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
