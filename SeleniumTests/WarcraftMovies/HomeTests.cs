using NUnit.Framework;
using SeleniumFramework.Pages.WarcraftMovies;
using SeleniumTests.BaseTests;

namespace SeleniumTests.WarcraftMovies
{
    internal class HomeTests : BaseTestWithChromeProfile
    {
        [Test]
        public void CloudflareDemo()
        {
            Home.Open();
        }
    }
}
