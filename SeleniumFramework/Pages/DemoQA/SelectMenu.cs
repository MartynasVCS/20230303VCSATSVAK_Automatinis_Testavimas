using System;

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
    }
}
