using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using September2020.Pages;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace September2020.StepDefinitions
{
    [Binding]
    public sealed class TMStefDefinitions
    {
        IWebDriver driver;

        [BeforeScenario]
        public void LoginToTurnUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            // Object init and define for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }

        [AfterScenario]
        public void Dispose()
        {
            // close the window and release memory.
            driver.Dispose();
        }


        [Given(@"I navigate to the TM")]
        public void GivenINavigateToTheTM()
        {
            // object of the class
            var homePage = new HomePage();

            homePage.NavigateToTM(driver);
        }

    }
}
