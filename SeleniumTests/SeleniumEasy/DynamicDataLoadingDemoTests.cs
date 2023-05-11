using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumFramework;

namespace SeleniumTests.SeleniumEasy
{
    internal class DynamicDataLoadingDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            DynamicDataLoadingDemo.Open();
        }

        [Test]
        public void WaitForUserInformation()
        {
            DynamicDataLoadingDemo.ClickGetNewUserButton();
            string userInformation = DynamicDataLoadingDemo.GetUserInformation();

            StringAssert.Contains("First Name : ", userInformation);
            StringAssert.Contains("Last Name : ", userInformation);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.ShutdownDriver();
        }
    }
}
