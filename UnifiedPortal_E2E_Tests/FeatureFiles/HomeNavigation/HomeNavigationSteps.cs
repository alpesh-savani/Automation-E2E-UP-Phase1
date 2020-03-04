using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using UnifiedPortal_E2E_Tests.BaseClasses;
using UnifiedPortal_E2E_Tests.PageObject;

namespace UnifiedPortal_E2E_Tests.FeatureFiles.HomeNavigation
{
    [Binding]
    public class HomeNavigationSteps : BaseClass
    {
        [Given]
        public void GivenIAmOnTheUnifiedPortalAdminSignInPage()
        {
            OpenAdminBrowser();
        }

        [Given]
        public void GivenIEnterValidAdminEmailAddress()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.EnterEmail.SendKeys("test_user_up-ext@system1group.com");
        }

        [Given]
        public void GivenIClickOnNextButton()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.NextButton.Click();
        }

        [Given]
        public void GivenIEnterValidAdminPassword()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.EnterPassword.SendKeys("Te$t1ngTeam");
        }

        [When]
        public void WhenIClickSignInButton()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.SignInButton.Click();
        }
        
        [When]
        public void WhenIClickOnYesButton()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.ConfirmationButton.Click();
        }
        
        [Then]
        public void ThenISouldBeAbleToNavigateToUnifiedPortalAdminPage()
        {
            var hNavigation = new HomeNavigationPage(driver);
            string expTitle = "Hi, test_user_up-ext";
            Assert.AreEqual(expTitle, hNavigation.AssertTitle.Text);
        }
        
        [Then]
        public void ThenIShouldBeAbleToSeeAdminHomeLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.AdminHomeLink.Displayed);
            CloseBrowser();
        }

        [Then]
        public void ThenIShouldBeAbleToNavigateToAdminHomeLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.AdminHomeLink.Displayed);
        }


        [Then]
        public void ThenIClickOnAccountsTabe()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.AccountsTab.Click();
        }

        [Then]
        public void ThenIClickOnAdminHomeLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.AdminHomeLink.Click();
        }

        [Then]
        public void ThenIShouldBeAbleToNavigateToAdminHomePage()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.AdminHomeLink.Displayed);
            CloseBrowser();
        }

        [Given]
        public void GivenIAmOnTheReposrtHubAdminSignInPage()
        {
            OpenRHAdminBrowser();
        }

        [Then]
        public void ThenISouldBeAbleToNavigateToReportHubAdminPage()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.AssertTotalSize.Displayed);
        }

        [Then]
        public void ThenIIShouldBeAbleToSeeAdminHomeLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.AdminHomeLink.Displayed);
            CloseBrowser();
        }

        [Then]
        public void ThenIClickOnAnyAccount()
        {
            var hNavigation = new HomeNavigationPage(driver);
            //hNavigation.ClickPageNumber.Click();
            //hNavigation.SelectAnyAccount.Click();
        }

        [Given]
        public void GivenINavigateToUnifiedPortalSignInPage()
        {
            OpenBrowser();
        }


        [Given]
        public void GivenIEnter_P0_InEmailAddressField(string useremail)
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.EnterEmail.SendKeys(useremail);
        }

        [Given]
        public void GivenIEnter_P0_InPasswordField(string userpassword)
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.EnterPassword.SendKeys(userpassword);
        }

        [Given]
        public void GivenIClickSignInButton()
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.ClickOnSignIn.Click();
        }

        [Given]
        public void GivenIShouldBeAbleToNavigateToUnifiedPortalHomePage()
        {
            var signInPage = new UserSignInPage(driver);
            Assert.AreEqual(signInPage.TitleText.Text, "Hi, S5 Alpesh");
        }

        [Given]
        public void GivenICanSeeReportHubSVGImage()
        {
            var signInPage = new UserSignInPage(driver);
            Assert.IsTrue(signInPage.ReportHubImage.Displayed);
        }

        [When]
        public void WhenIClickOnReportHubSVGImage()
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.ReportHubImage.Click();
        }

        [Then]
        public void ThenIShouldBeAbleToNavigateToReportHubHomePageInNewTab()
        {
            var hNavigation = new HomeNavigationPage(driver);
            var windowids = driver.WindowHandles;
            driver.SwitchTo().Window(windowids[1]);
            string expTitle = "Hi, S5 Alpesh";
            Assert.AreEqual(hNavigation.AssertTitle.Text, expTitle);
        }

        [Then]
        public void ThenICanSeeReportsLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.ReportsLabel.Displayed);
            CloseBrowser();
        }

        [Given]
        public void GivenITypeValidEmailAddressInEmailAddressField()
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.EnterEmail.SendKeys("");
        }

        [Given]
        public void GivenITypeValidPasswordInPasswordField()
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.EnterPassword.SendKeys("");
        }

        [Given]
        public void GivenIClickOnReportHubSVGImage()
        {
            var signInPage = new UserSignInPage(driver);
            signInPage.ReportHubImage.Click();
        }

        [Given]
        public void GivenIShouldBeAbleToNavigateToReportHubHomePageInNewTab()
        {
            var hNavigation = new HomeNavigationPage(driver);
            var windowids = driver.WindowHandles;
            driver.SwitchTo().Window(windowids[1]);
            string expTitle = "Hi, S5 Alpesh";
            Assert.AreEqual(hNavigation.AssertTitle.Text, expTitle);
        }

        [Given]
        public void GivenICanSeeReportsLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.ReportsLabel.Displayed);
        }

        [Given]
        public void GivenINavigateToAnySubFolders()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Actions actions = new Actions(driver);
            IWebElement elementLocator = hNavigation.DoubleClickFolder;
            actions.DoubleClick(elementLocator).Perform();
        }

        [When]
        public void WhenIClickOnReportsLabel()
        {
            var hNavigation = new HomeNavigationPage(driver);
            hNavigation.ReportsLabel.Click();
        }

        [Then]
        public void ThenIShouldBeAbleToNavigateToReportHubHomePage()
        {
            var hNavigation = new HomeNavigationPage(driver);
            Assert.IsTrue(hNavigation.AssertPublishedReportText.Displayed);
            CloseBrowser();
        }

    }
}
