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
    public class SignUpPage : BasePage
    {
        private IWebDriver _driver;
        public SignUpPage(IWebDriver driver) : base(driver)
        {
        }

        #region Registration
        public IWebElement SignUpNowLink => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@id='createAccount']")));

        public IWebElement EmailTextBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#email")));

        public IWebElement SendVerificationCodeButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#email_ver_but_send")));

        public IWebElement VerificationCodeTextBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input#email_ver_input")));

        public IWebElement VerifyCodeButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#email_ver_but_verify")));

        public IWebElement NewPasswordTextBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#newPassword")));

        public IWebElement ConfirmPasswordTextBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#reenterPassword")));

        public IWebElement GivenNameTextBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#givenName")));

        public IWebElement LastNameTextBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#surname")));

        public IWebElement TermsAndConditionsCheckBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector
                                                                                                    ("#extension_AgreedTermsAndConditions_True")));
        public IWebElement CreateButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#continue")));

        public IWebElement ErrorMessage => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div#attributeList li:nth-child(9) > div > div > p")));

        public IWebElement IncorrectCodeError => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#email_fail_retry")));

        #endregion Registration


        #region mailosaurs
        
        public IWebElement EnterEmail => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input#email")));
        public IWebElement EnterPassword => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input#password")));
        public IWebElement LoginButton => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.login-wrapper div.paper:nth-child(2) div.paper-body " +
                                                                            "form:nth-child(1) div.text-center:nth-child(2) > button.btn.btn-lg.btn-primary:nth-child(3)")));
        public IWebElement SelectServer => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("section#mailosaur-content div:nth-child(1) > a")));
        public IWebElement RefreshInbox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("i.fa.fa-refresh")));
        public IWebElement ClickServerLink => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(text(),'Servers')]")));
        public IWebElement SelServer => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div.paper div.paper-body div.stack div.stack-item div:nth-child(1) > a.mailbox-name")));
        public IWebElement VerificationCode => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("span#BodyPlaceholder_UserVerificationEmailBodySentence2")));
        public IWebElement ClickEmail => Wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("div#region-email-list div.subject")));

        #endregion mailosaurs

        public void EnterNewEmailAddress(string emailAddress)
        {
            EmailTextBox.Clear();
            EmailTextBox.SendKeys(emailAddress);

            SendVerificationCodeButton.Click();
        }

        public void EnterVerificationCode(string CleanCode)
        {
            VerificationCodeTextBox.Clear();
            VerificationCodeTextBox.SendKeys(CleanCode);

            VerifyCodeButton.Click();
        }

        public void EnterUserDetails(User user)
        {
            NewPasswordTextBox.Clear();
            NewPasswordTextBox.SendKeys(user.Password);

            ConfirmPasswordTextBox.Clear();
            ConfirmPasswordTextBox.SendKeys(user.Password);

            GivenNameTextBox.Clear();
            GivenNameTextBox.SendKeys(user.GivenName);

            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys(user.LastName);

            TermsAndConditionsCheckBox.Click();
        }  
    }
}