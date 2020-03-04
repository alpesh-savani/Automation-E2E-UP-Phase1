using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedPortal_E2E_Tests.BaseClasses
{
    public abstract class BasePage
    {
        protected static WebDriverWait Wait;

        protected BasePage(IWebDriver driver)
        {
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
    }
}
