using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnifiedPortal_E2E_Tests.BaseClasses
{
    [TestFixture]
    public class BaseClass
    {
        public static IWebDriver driver;

        [SetUp]
        //[BeforeScenario]
        public static void OpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://uks-up-unifiedportal-ui-tst.azurewebsites.net/");
            driver.Manage().Window.Maximize();
        }

        public static void OpenAdminBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://uks-up-unifiedportal-ui-tst.azurewebsites.net/admin");
            driver.Manage().Window.Maximize();
        }

        public void OpenRHAdminBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://uks-up-reporthub-ui-tst.azurewebsites.net/admin/");
            driver.Manage().Window.Maximize();
        }

        public void OpenFireFox()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://uks-up-unifiedportal-ui-tst.azurewebsites.net/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        public static void OpenFirefoxAdminBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://uks-up-unifiedportal-ui-tst.azurewebsites.net/admin");
            driver.Manage().Window.Maximize();
        }

        public void OpenFirefoxRHAdminBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://uks-up-reporthub-ui-tst.azurewebsites.net/admin/");
            driver.Manage().Window.Maximize();
        }


        [TearDown]
        //[AfterScenario]
        public static void CloseBrowser()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();
            driver.Quit();
        }

        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    OpenBrowser();
        //}

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    CloseBrowser();
        //}

            public void ClearAllCokkies()
        {

            //DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
            //capabilities.SetCapability(CapabilityType.BrowserName("Chrome").ENSURING_CLEAN_SESSION, true);

            //ChromeOptions opts = new ChromeOptions();
            //opts.AddArguments("start-maximized");
            //capabilities.SetCapability(ChromeOptions.Capability, opts);

            //IWebDriver driver = new ChromeDriver(capabilities);

        }
    }
}
