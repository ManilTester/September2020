using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2020.Helpers;
using September2020.Pages;
using System;
using System.Threading;

namespace September2020
{
    [TestFixture, Description("This fixture contains Time and Material tests")]
    [Parallelizable]
    class Program : CommonDriver
    {
        [Test, Description("Check if the user is able to create time successfully")]
        public void CreateNewTMTest()
        {
            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Test 1 - Check if the user is able to create time successfully

            // Object init and define for TM page
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver);
        }

        [Test, Description("Check if the user is able to edit time successfully")]
        public void EditTMTest()
        {
            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Test 2 - Check if the user is able to edit time successfully

            // Object init and define for TM page
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver);
        }

        [Test, Description("Check if the user is able to delete time successfully")]
        public void DeleteTMTest()
        {
            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // Test 3 - Check if the user is able to delete time successfully

            // Object init and define for TM page
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);
        }
    }


}
