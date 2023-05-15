using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;
using System.Collections.Generic;

namespace SeleniumTests.SeleniumEasy
{
    internal class BasicSelectDropdownDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicSelectDropdownDemo.Open();
        }

        [Test]
        public void Demo()
        {
            List<string> expectedValues = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Assert.IsTrue(BasicSelectDropdownDemo.CheckIfActualValuesContainAllOfTheExpectedValues(expectedValues));
        }
    }
}
