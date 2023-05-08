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
            Common.SendKeys(Locators.TextBox.inputName, name);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeys(Locators.TextBox.inputEmail, email);
        }

        public static void EnterCurrentAddress(string currentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputCurrentAddress, currentAddress);
        }

        public static void EnterPermanentAddress(string permanentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputPermanentAddress, permanentAddress);
        }

        public static void ClickSubmitButton()
        {
            Common.ScrollUntilElementIsClickable(Locators.TextBox.buttonSubmit);
        }

        public static string GetName()
        {
            return Common.GetElementText(Locators.TextBox.outputName);
        }

        public static string GetEmail()
        {
            return Common.GetElementText(Locators.TextBox.outputEmail);
        }

        public static string GetCurrentAddress()
        {
            return Common.GetElementText(Locators.TextBox.outputCurrentAddress);
        }

        public static string GetPermanentAddress()
        {
            return Common.GetElementText(Locators.TextBox.outputPermanentAddress);
        }

        public static void ValidateEmailInputBorderColor()
        {
            string expectedColor = "rgb(255, 0, 0)";
            Common.WaitForElementCssAttributeValueToBe(Locators.TextBox.inputEmail, "border-color", expectedColor);
        }
    }
}
