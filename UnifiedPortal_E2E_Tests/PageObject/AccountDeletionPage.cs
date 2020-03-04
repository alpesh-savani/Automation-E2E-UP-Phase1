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
    public class AccountDeletionPage : BasePage
    {
        public IWebDriver driver;

        public AccountDeletionPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement EnterEmail => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='logonIdentifier']")));

        public IWebElement EnterPassword => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#password")));

        public IWebElement ClickOnSignIn => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Sign in')]")));

        public IWebElement SelectAccountForSession => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/button[2]")));

        public IWebElement SelectAccountText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[text()='Select Account']")));

        public IWebElement ActTitleText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='loggedInUser']")));

        public IWebElement ClickMyTeam => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@id='myTeam']")));

        public IWebElement DeleteCompanyAccountButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button#button__delete-company")));

        public IWebElement ClickConfirmationYes => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@id='button__modal-on-confirm']")));

        public IWebElement CancelRequestLink => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()=' Cancel request']")));

        public IWebElement SignOutLink => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@id='logOut']")));

        public IWebElement DeletionStringText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='u-error']")));

    }
}
