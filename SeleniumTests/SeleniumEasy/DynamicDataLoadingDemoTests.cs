using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;

namespace SeleniumTests.SeleniumEasy
{
    internal class DynamicDataLoadingDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
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
    }
}
