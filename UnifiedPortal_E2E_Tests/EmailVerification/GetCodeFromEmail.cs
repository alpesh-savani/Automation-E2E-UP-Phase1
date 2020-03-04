using Mailosaur;
using Mailosaur.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UnifiedPortal_E2E_Tests.EmailVerification
{
    public class GetCodeFromEmail
    {
        private IWebDriver _driver;
        private Header _header;
        private User _user = new User()
        {
            Username = $"{Guid.NewGuid()}.qug8ug4m@mailosaur.io",
            Password = "TestPa$$word",
            GivenName = "Test",
            LastName = "Automation",
        };

        public void ThenAnEmailIsSentToThatEmailAddress()
        { 

            
            var client = new MailosaurClient("OcC8OD35Fzk0v9M", "https://mailosaur.com");

            var criteria = new SearchCriteria
            {
                SentTo = _user.Username
            };

            var message = client.Messages.Get("qug8ug4m", criteria);

            Assert.Equals("System1 Group TST account email verification code", message.Subject);

                    var body = new XmlDocument();
                    body.LoadXml(message.Html.Body);

                    var code = body.GetElementById("BodyPlaceholder_UserVerificationEmailBodySentence2");

            //Assert.StartsWith("Your code is: 123456", code.InnerText);

            var splitText = code.InnerText.Split(new[] { ":" }, StringSplitOptions.None);
        }
    }
}
