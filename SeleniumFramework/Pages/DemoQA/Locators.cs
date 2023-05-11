namespace SeleniumFramework.Pages.DemoQA
{
    internal static class Locators
    {
        internal static class TextBox
        {
            internal static string inputName = "//*[@id='userName']";
            internal static string inputEmail = "//*[@id='userEmail']";
            internal static string inputCurrentAddress = "//*[@id='currentAddress']";
            internal static string inputPermanentAddress = "//*[@id='permanentAddress']";

            internal static string buttonSubmit = "//*[@id='submit']";

            internal static string outputName = "//*[@id='name']";
            internal static string outputEmail = "//*[@id='email']";
            internal static string outputCurrentAddress = "//*[@id='output']//*[@id='currentAddress']";
            internal static string outputPermanentAddress = "//*[@id='output']//*[@id='permanentAddress']";
        }

        internal static class DynamicProperties
        {
            internal static string buttonFirst = "//*[@id='enableAfter']";
            internal static string buttonThird = "//*[@id='visibleAfter']";
        }
    }
}
