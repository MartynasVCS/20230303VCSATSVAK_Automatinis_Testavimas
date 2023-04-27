using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestsWithoutPOM
{
    public class Google
    {
        [Test]
        public void VilniusCodingSchoolAddress()
        {
            string expectedResult = "Žalgirio gatvė 90,\r\nA korpusas, 2 aukštas,\r\nVilnius";

            // Atidarome svetainę
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";

            // Uždarome cookies langą
            IWebElement buttonRejectCookies = driver.FindElement(By.XPath("(//*[@id='CXQnmb']//button)[3]"));
            buttonRejectCookies.Click();

            // Įvedame tekstą į paieškos laukelį
            IWebElement inputSearch = driver.FindElement(By.Name("q"));
            inputSearch.SendKeys("Vilnius coding school");

            // Paspaudžiame ant Google logotipo, kad uždarytume suggestions langą kuris užstoja paieškos mygtuką
            IWebElement imageGoogle = driver.FindElement(By.ClassName("lnXdpd"));
            imageGoogle.Click();

            // Paspaudžiame paieškos mygtuką
            IWebElement buttonSearch = driver.FindElement(By.XPath("(//*[@name='btnK'])[2]"));
            buttonSearch.Click();

            // Paspaudžiame ant pirmo rezultato (ne reklaminio)
            IWebElement linkFirstResult = driver.FindElement(By.XPath("//*[@id='res']//a"));
            linkFirstResult.Click();

            // Vilnius Coding School svetainėje uždarome reklamą
            IWebElement buttonCloseAd = driver.FindElement(By.XPath("//*[@aria-label='Close']"));
            // Palaukiame kol reklama atsiras
            System.Threading.Thread.Sleep(2000);
            buttonCloseAd.Click();
            // Palaukiame kol reklama išnyks
            System.Threading.Thread.Sleep(2000);

            // Nuskaitome Vilniaus mokyklos adresą
            IWebElement textVilniusSchoolAddress = driver.FindElement(By.XPath("//*[@id='kontaktai']//h3[text()='VILNIUS CODING SCHOOL']/following-sibling::div/p"));
            string actualResult = textVilniusSchoolAddress.Text;

            // Palyginame reikšmes
            StringAssert.Contains(expectedResult, actualResult);

            // Uždarome naršyklę
            driver.Quit();
        }
    }
}
