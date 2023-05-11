namespace SeleniumFramework.Pages.DemoQA
{
    public class SelectMenu
    {
        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/select-menu");
        }

        public static void SelectColorInOldStyleMenu(string expectedColor)
        {
            Common.SelectOptionByText(Locators.SelectMenu.selectOldStyleMenu, expectedColor);
        }

        public static string GetSelectedColorInOldStyleMenu()
        {
            return Common.GetSelectedOption(Locators.SelectMenu.selectOldStyleMenu);
        }

        public static void SelectTitleInSelectOneMenu(string expectedTitle)
        {
            Common.Click(Locators.SelectMenu.selectSelectOneMenu);
            Common.Click($"//*[contains(@id, 'react-select') and contains(text(),'{expectedTitle}')]");
        }

        public static string GetSelectedTitleInSelectOneMenu()
        {
            return Common.GetElementText(Locators.SelectMenu.selectSelectOneMenu);
        }
    }
}
