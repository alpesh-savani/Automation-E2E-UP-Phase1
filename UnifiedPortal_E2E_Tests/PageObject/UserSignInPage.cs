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
    public class UserSignInPage : BasePage
    {
        private IWebDriver driver;

        public UserSignInPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement EnterEmail => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='logonIdentifier']")));

        public IWebElement EnterPassword => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#password")));

        public IWebElement ClickOnSignIn => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(text(),'Sign in')]")));

        public IWebElement TitleText => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("loggedInUser")));

        public IWebElement ErrorMessage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'Your password is incorrect')]")));

        public IWebElement AdRatingImage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'The largest database of rated ads from the top 25')]")));

        public IWebElement ReportHubImage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'All your files in one place.')]")));

        public IWebElement BrandPortalImage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'Measuring Fame, Feeling & Fluency to understand yo')]")));

        public IWebElement EditProfile => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@id='editProfile']")));

        public IWebElement FooterText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='c-footer__logo']//img")));

        public IWebElement SignOutLink => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[@id='logOut']")));

        public IWebElement BPAssertText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//th[text()='Survey' and @xpath='1']")));

        public IWebElement RHAssertText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@id='id_Reports']")));

        public IWebElement ARAssertText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//img[@id='logo-system-1']")));

        public IWebElement ClickHeaderLogo => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//img[@alt='company logo' and @xpath='1']")));

        public IWebElement ProjectLabel => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='/Projects']")));

        public IWebElement SelectAccountForSession => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='S03-Alpesh']")));

        public IWebElement AssertText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Ad-Testing']")));

        public IWebElement SelectAccountText => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[text()='Select Account']")));

        public IWebElement ClickSignOut => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button#logOut")));

        public IWebElement MyTeamLink => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a#myTeam")));

    }
}
