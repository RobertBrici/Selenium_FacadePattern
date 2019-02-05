using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Date;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class Authentication : BaseTest
    {
        [TestMethod]
        public void LoginAndOut()
        {
            var SectionUrl = "?controller=authentication&back=my-account";
            var ExpectedSuccessLogIn = "Welcome to your account. Here you can manage all of your personal information and orders.";
            var ExpectedSuccessLogOut = "ALREADY REGISTERED?";
            var Credentials = new InfoClient()
            {
                UserEmail = "robert_br96@yahoo.com",
                Password = "123456789"
            };
            new LoginRegisterFacade().LoginAndOut(SectionUrl, ExpectedSuccessLogIn, ExpectedSuccessLogOut, Credentials);
        }

        [TestMethod]
        public void LoginInvalidCredentials()
        {
            var SectionUrl = "?controller=authentication&back=my-account";
            var DenialMsg = "Authentication failed.";
            var WrongCredentialsClient = new InfoClient()
            {
                UserEmail = "robert_br96@yahoo.com",
                Password = "wrongpassword"
            };
            new LoginRegisterFacade().LoginWrongPassword(SectionUrl, DenialMsg, WrongCredentialsClient);
        }
    }
}
