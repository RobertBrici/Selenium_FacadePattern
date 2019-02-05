using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;
using UnitTestProject1.Pagini.PaginiComandaProdus;

namespace UnitTestProject1.Pagini.PaginaComandaProdus
{
    public class DeliveryInfoPageValidator : BasePageValidator<DeliveryInfoPageMap>
    {
        public void Subtotal(string ExpectedSubtotal)
        {
            Assert.AreEqual<string>(ExpectedSubtotal, Map.TotalPrice.Text);
        }

        public void SentOrderConfirmation(string ConfirmationMessage)
        {
            Assert.AreEqual<string>(ConfirmationMessage, Map.OrderConfirmation.Text);
        }
    }
}
