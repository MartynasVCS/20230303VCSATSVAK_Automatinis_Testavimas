using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class FramesTests : BaseTest
    {
        [Test]
        public void Demo()
        {
            string expectedValue = "This is a sample page";
            
            Frames.Open();
            string actualValue = Frames.GetHeadingText();

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
