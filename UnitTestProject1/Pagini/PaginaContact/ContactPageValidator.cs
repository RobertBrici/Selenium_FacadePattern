using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaContact
{
    class ContactPageValidator : BasePageValidator<ContactPageMap>
    {
        public void ConfirmationMessage(string Message)
        {
            Assert.AreEqual<string>(Message, Map.ConfirmationMessage.Text);
        }
    }
}
