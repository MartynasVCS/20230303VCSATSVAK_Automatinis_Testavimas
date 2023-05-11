namespace SeleniumFramework.Pages.DemoQA
{
    public class Buttons
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/buttons");
        }

        public static void DoubleClickFirstButton()
        {
            Common.DoubleClick(Locators.Buttons.buttonFirst);
        }

        public static string GetDoubleClickActionOutput()
        {
            return Common.GetElementText(Locators.Buttons.outputDoubleClick);
        }

        public static void RightClickSecondButton()
        {
            Common.RightClick(Locators.Buttons.buttonSecond);
        }

        public static string GetRightClickActionOutput()
        {
            return Common.GetElementText(Locators.Buttons.outputRightClick);
        }

        public static void LeftClickThirdButton()
        {
            Common.Click(Locators.Buttons.buttonThird);
        }

        public static string GetLeftClickActionOutput()
        {
            return Common.GetElementText(Locators.Buttons.outputLeftClick);
        }
    }
}
