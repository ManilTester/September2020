using OpenQA.Selenium;
using September2020.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace September2020.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // click administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Wait.WaitForElement(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            // click time and material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
        }

        public void NavigateToCompany(IWebDriver driver)
        {
            // To-do - steps to navigate to Company page
        }
    }
}
