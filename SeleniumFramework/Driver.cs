﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--window-size=1920,1080");
            //options.AddArgument("--headless=new");
            driver.Value = new ChromeDriver(options);
        }

        public static void InitializeDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userDataDir}");
            options.AddArgument($"--profile-directory={profileDir}");
            driver.Value = new ChromeDriver(options);
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        internal static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Value.Quit();
        }

        public static void TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-screenshot";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile($"{screenshotFilePath}.png", ScreenshotImageFormat.Png);
        }
    }
}
