using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace September2020.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            // launch browser and enter the url
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // maximise web browser
            driver.Manage().Window.Maximize();

            // identify username textbox and enter username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            // identify password textbox and enter password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // identify login button and click login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            try
            {
                // validate if the user had logged in successfully
                IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
                Assert.That(helloHari.Text == "Hello hari!");

            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login step", ex.Message);
            }



        }
    }
}
