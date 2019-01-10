using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Training8.Utilities
{
    [Binding]
    public sealed class Hooks
    {
        ChromeDriver driver;
        FirefoxDriver driverFirefox;
        InternetExplorerDriver driverIE;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //ChromeDriver driver = new ChromeDriver();
            //driver = new ChromeDriver();

            //driverFirefox = new FirefoxDriver();

            driverIE = new InternetExplorerDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();

           // driverFirefox.Quit();
        }
    }
}
