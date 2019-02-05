using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Date;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class BusinessProcess : BaseTest
    {
        [TestMethod]
        public void Purchase_Item()
        {
            var ItemUrl = "?id_product=1&controller=product";
            var ItemPrice = "$16.51";
            var ItemX2Price = "$33.02";
            var TotalPrice = "$35.02";
            var ExpectedConfirmationMsg = "Your order on My Store is complete.";
            var CurrentInfoClient = new InfoClient()
            {
                FirstName = "Robert",
                LastName = "Brici",
                Company = "SC ROBERT SRL",
                Address = "Strada TEsterului, Nr2",
                City = "South Park",
                State = "Colorado",
                PostalCode = "17294",
                Country = "United States",
                HomePhone = "003425",
                MobilePhone = "0711111",
                AdditionalInformation = "test",
                AddressTitleForFutureReference = "wqdwyumyuuuu", //de schimbat dupa fiecare rulare

            };
            var currentCredentialsClient = new InfoClient()
            {
                UserEmail = "robert_br96@yahoo.com",
                Password = "123456789"
            };
            new OrderProductFacade().CumparareProdus(ItemUrl, ItemPrice, ItemX2Price, TotalPrice, CurrentInfoClient, currentCredentialsClient, ExpectedConfirmationMsg);
        }
    }
}
