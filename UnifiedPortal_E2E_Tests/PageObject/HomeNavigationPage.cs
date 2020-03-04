using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnifiedPortal_E2E_Tests.BaseClasses;

namespace UnifiedPortal_E2E_Tests.PageObject
{
    public class HomeNavigationPage : BasePage
    {
        public HomeNavigationPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement EnterEmail => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#i0116")));

        public IWebElement NextButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#idSIButton9")));

        public IWebElement EnterPassword => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#i0118")));

        public IWebElement SignInButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#idSIButton9")));

        public IWebElement ConfirmationButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#idSIButton9")));

        public IWebElement AssertTitle => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#loggedInUser")));

        public IWebElement AdminHomeLink => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/span[1]")));

        public IWebElement AccountsTab => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#button__id__tab-heading-1")));

        public IWebElement AssertTotalSize => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//th[text()='Total Size'])[1]")));

        public IWebElement ClickPageNumber => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div#root li:nth-child(3) > a")));

        public IWebElement SelectAnyAccount => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div#root tr:nth-child(7) > td:nth-child(1) > a")));
              
        public IWebElement ConfirmanButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#idSIButton9")));

        public IWebElement AssertPublishedReportText => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div#root>div>div>div:nth-of-type(2)>div>div>h2")));
        public IWebElement ReportsLabel => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.c-layout div.c-layout__container:nth-child(1) " +
                                                                                                                "div.p-home div.o-page-content div.u-flex > h2.u-flex-grow")));
        public IWebElement DoubleClickFolder => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='c-file-viewer__contents']//button[1]")));


    }
}
