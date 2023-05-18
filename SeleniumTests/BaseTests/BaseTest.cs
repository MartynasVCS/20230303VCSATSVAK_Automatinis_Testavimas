using NUnit.Framework;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.TakeScreenshot();
            Driver.ShutdownDriver();
        }
    }
}
