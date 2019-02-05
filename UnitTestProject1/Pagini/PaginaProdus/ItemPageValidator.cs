using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaProdus
{
    public class ItemPageValidator : BasePageValidator<ItemPageMap>
    {
        public void Price(string ExpectedPrice)
        {
            Assert.AreEqual<string>(ExpectedPrice, Map.DisplayedPrice.Text);
        }

        public void PriceFor2Buc(string ExpectedPriceFor2)
        {
            Assert.AreEqual<string>(ExpectedPriceFor2, Map.DisplayedPrice.Text);
        }
    }
}
