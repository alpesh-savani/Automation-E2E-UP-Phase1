using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace UnifiedPortal_E2E_Tests.CompatibilityTest
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IWebDriver driver;
    //        DesiredCapabilities caps = new DesiredCapabilities();
    //        caps.SetCapability("browser", "Edge");
    //        caps.SetCapability("browser_version", "79.0 beta");
    //        caps.SetCapability("os", "Windows");
    //        caps.SetCapability("os_version", "10");
    //        caps.SetCapability("resolution", "1024x768");
    //        caps.SetCapability("browserstack.user", "testing1586");
    //        caps.SetCapability("browserstack.key", "3NPpp7u7ZAXhW5a2ranr");
    //        caps.SetCapability("name", "Bstack-[C_sharp] Sample Test");

    //        driver = new RemoteWebDriver(
    //          new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps);
    //        driver.Navigate().GoToUrl("http://www.google.com/ncr");
    //        Console.WriteLine(driver.Title);

    //        IWebElement query = driver.FindElement(By.Name("q"));
    //        query.SendKeys("Browserstack");
    //        query.Submit();
    //        Console.WriteLine(driver.Title);

    //        driver.Quit();
    //    }
    //}
}
