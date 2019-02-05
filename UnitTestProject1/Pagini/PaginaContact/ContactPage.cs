using UnitTestProject1.Base;
using UnitTestProject1.Date;

namespace UnitTestProject1.Pagini.PaginaContact
{
    class ContactPage : BasePage<ContactPageMap, ContactPageValidator>
    {
        public ContactPage() : base(@"http://automationpractice.com/index.php")
        {

        }

        public void FillContactForm(OtherInfo Info)
        {
            Map.SubjectHeadingDown.SelectByValue("2");
            Map.EmailBox.SendKeys(Info.Email);
            Map.OrderReferenceBox.SendKeys(Info.OrderReference);
            Map.MessageBox.SendKeys(Info.Message);
        }

        public void SubmitContactForm() => Map.FormSendButton.Click();

    }
}
