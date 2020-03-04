using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnifiedPortal_E2E_Tests.BaseClasses
{
    public class UtilityHelper
    {
        public IWebDriver driver;

        public UtilityHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static void GetImplicitWait(int wait)
        {
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(wait));
        }

        //public static void EnterText(IWebElement element, String text)
        //{
        //    element.SendKeys(text);
        //}

        //public static void ClickElement(IWebElement element)
        //{
        //    element.Click();
        //}

        //public static String GetText(IWebElement element)
        //{
        //    return element.Text;            
        //}
        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed;
        }

        public static void AllowWaitToFindElement()
        {
            Thread.Sleep(2000);
        }

        public static string GetTitle()
        {
            return ObjectRepository.driver.Title;
        }

        public string GetURL()
        {
            return ObjectRepository.driver.Url;
        }

        public void ManageTabs()
        {
            String mainWindow = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(mainWindow);
        }

        private static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;
                return false;
            });
        }

        public static bool WaitForWebElement(By locator, TimeSpan timeout)
        {
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            var wait = GetWebdriverWait(timeout);
            var flag = wait.Until(WaitForWebElementFunc(locator));
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(30));
            return flag;
        }

        public static WebDriverWait GetWebdriverWait(TimeSpan timeout)
        {
            ObjectRepository.driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(ObjectRepository.driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait;
        }

            //public void ExplicitWait(By locator)
            //{
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            //    wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            //}

            //public int GetElementLoadTimeOut()
            //{
            //    ObjectRepository.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            //    if (timeout == null)
            //        return 30;
            //    return Convert.ToInt32(timeout);
            //}

        }
}
