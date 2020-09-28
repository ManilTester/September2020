using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2020.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace September2020.Helpers
{
    public class CommonDriver
    {
        // init driver
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginToTurnUp()
        {
            // define webdriver
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            // Object init and define for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void TestClosure()
        {
            // close instances of open chrome driver 
            driver.Quit();
        }
    }
}
