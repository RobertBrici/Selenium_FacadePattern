using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Date;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class Registration : BaseTest
    {
        [TestMethod]
        public void RegisterNewAccount()
        {
            var SectionUrl = "?controller=authentication&back=my-account";
            var ExpectedWelcomeMsg = "Welcome to your account. Here you can manage all of your personal information and orders.";
            var RegisterInfoClient = new InfoClient()
            {
                FirstName = "Testing",
                LastName = "REgister",
                Password = "123sac",
                Birthday = "12",
                Birthmonth = "May",
                Birthyear = "1995",
                Company = "SC sdas SRL",
                Address = "Strada TEsterului, Nr2",
                City = "South Park",
                State = "Colorado",
                PostalCode = "17294",
                Country = "United States",
                HomePhone = "003425",
                MobilePhone = "0711111",
                AdditionalInformation = "test",
                AddressTitleForFutureReference = "tjyt7ii8kkkkk", //de schimbat dupa fiecare rulare

            };
            var NewUserEmail = new OtherInfo()
            {
                Email = "asfasf33e0o0o@yahoo.com" //de schimbat dupa fiecare rulare
            };
            new LoginRegisterFacade().RegisterAccount(SectionUrl, RegisterInfoClient, ExpectedWelcomeMsg, NewUserEmail);
        }

        [TestMethod]
        public void RegisterAlreadyUsedMail()
        {
            var SectionUrl = "?controller=authentication&back=my-account";
            var DenialMsg = "An account using this email address has already been registered. Please enter a valid password or request a new one.";
            var UsedEmail = new OtherInfo()
            {
                Email = "robert_br96@yahoo.com"
            };
            new LoginRegisterFacade().RegisterAlreadyUsedMail(SectionUrl, DenialMsg, UsedEmail);
        }
    }
}
