using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Date;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class OtherFeatures : BaseTest
    {
        [TestMethod]
        public void CustomizeDressezChoice()
        {
            var SectionUrl = "?id_category=8&controller=category";
            var Msg = "There are no products.";
            new DressesFacade().CustomizeDresses(SectionUrl, Msg);
        }

        [TestMethod]
        public void ContactUs()
        {
            var SectionUrl = "?controller=contact";
            var Confirmation = "Your message has been successfully sent to our team.";
            var FormInfo = new OtherInfo()
            {
                Email = "robert_br96@yahoo.com",
                OrderReference = "10",
                Message = "test"
            };
            new ContactFacade().ContactProvider(SectionUrl, FormInfo, Confirmation);
        }

        [TestMethod]
        public void SubmitReview()
        {
            var SectionUrl = "?id_product=6&controller=product";
            var Title = "Test Title";
            var Comment = "Test Comment";
            var ExpectedSubmitted = "Your comment has been added and will be available once approved by a moderator";
            var Credentials = new InfoClient()
            {
                UserEmail = "robert_br96@yahoo.com",
                Password = "123456789"
            };
            new ReviewFacade().CreateReview(SectionUrl, Title, Comment, Credentials, ExpectedSubmitted);
        }
    }
}
