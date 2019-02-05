using UnitTestProject1.Date;
using UnitTestProject1.Pagini.PaginaContact;

namespace UnitTestProject1
{
    class ContactFacade
    {
        private ContactPage _Contact;
        public ContactPage ContactPage
        {
            get
            {
                if (_Contact == null)
                {
                    _Contact = new ContactPage();
                }
                return _Contact;
            }
        }

        public void ContactProvider(string Adress, OtherInfo Info, string ExpectedMsg)
        {
            ContactPage.Navigate(Adress);
            ContactPage.FillContactForm(Info);
            ContactPage.SubmitContactForm();
            ContactPage.Validate().ConfirmationMessage(ExpectedMsg);
        }
    }
}
