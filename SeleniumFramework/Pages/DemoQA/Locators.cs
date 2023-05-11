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

        internal static class Buttons
        {
            internal static string buttonFirst = "//*[@id='doubleClickBtn']";
            internal static string outputDoubleClick = "//*[@id='doubleClickMessage']";
            internal static string buttonSecond = "//*[@id='rightClickBtn']";
            internal static string outputRightClick = "//*[@id='rightClickMessage']";
            internal static string buttonThird = "(//*[contains(@class, 'btn-primary')])[3]";
            internal static string outputLeftClick = "//*[@id='dynamicClickMessage']";
        }

        internal static class SelectMenu
        {
            internal static string selectOldStyleMenu = "//*[@id='oldSelectMenu']";
            internal static string selectSelectOneMenu = "//*[@id='selectOne']";
        }
    }
}
