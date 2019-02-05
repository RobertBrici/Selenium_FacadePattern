using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaTShirts
{
    public class DressesPageValidator : BasePageValidator<DressesPageMap>
    {
        public void NoProductsMsg(string ExpectedResult)
        {
            Assert.AreEqual<string>(ExpectedResult, Map.NoProductsMessage.Text);
        }
    }
}
