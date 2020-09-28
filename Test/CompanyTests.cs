using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2020.Helpers;
using September2020.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace September2020.Test
{
    [TestFixture, Description("This fixture contains Company tests")]
    [Parallelizable]
    class CompanyTests : CommonDriver
    {
        [Test, Description("Check if the user is able to create company successfully")]
        public void CreateNewCompanyTest()
        {
            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Test 1 - Check if the user is able to create company successfully

            // Object init and define for TM page
            CompanyPage companyObj = new CompanyPage();
            companyObj.CreateCompany(driver);
        }

        [Test, Description("Check if the user is able to edit comapny successfully")]
        public void EditCompanyTest()
        {
            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Test 2 - Check if the user is able to create company successfully

            // Object init and define for TM page
            CompanyPage companyObj = new CompanyPage();
            companyObj.EditCompany(driver);
        }

        [Test, Description("Check if the user is able to delete company successfully")]
        public void DeleteCompanyTest()
        {
            // Object init and define for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToCompany(driver);

            // Test 3 - Check if the user is able to delete company successfully

            // Object init and define for TM page
            CompanyPage companyObj = new CompanyPage();
            companyObj.DeleteCompany(driver);
        }
    }
}
