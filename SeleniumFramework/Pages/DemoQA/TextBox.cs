namespace SeleniumFramework.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string name)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, name);
        }

        public static void EnterEmail(string email)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, email);
        }

        public static void EnterCurrentAddress(string currentAddress)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, currentAddress);
        }

        public static void EnterPermanentAddress(string permanentAddress)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, permanentAddress);
        }

        public static void ClickSubmitButton()
        {
            string locator = "//*[@id='submit']";
            Common.ScrollUntilElementIsClickable(locator);
        }

        public static string GetName()
        {
            string locator = "//*[@id='name']";
            return Common.GetElementText(locator);
        }

        public static string GetEmail()
        {
            string locator = "//*[@id='email']";
            return Common.GetElementText(locator);
        }

        public static string GetCurrentAddress()
        {
            string locator = "//*[@id='output']//*[@id='currentAddress']";
            return Common.GetElementText(locator);
        }

        public static string GetPermanentAddress()
        {
            string locator = "//*[@id='output']//*[@id='permanentAddress']";
            return Common.GetElementText(locator);
        }

        public static void ValidateEmailInputBorderColor()
        {
            string locator = "//*[@id='userEmail']";
            string expectedColor = "rgb(255, 0, 0)";
            Common.WaitForElementCssAttributeValueToBe(locator, "border-color", expectedColor);
        }
    }
}
