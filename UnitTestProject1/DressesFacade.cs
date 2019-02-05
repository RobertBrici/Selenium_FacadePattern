using UnitTestProject1.Pagini.PaginaTShirts;

namespace UnitTestProject1
{
    class DressesFacade
    {
        private DressesPage _Dresses;

        public DressesPage DressesPage
        {
            get
            {
                if (_Dresses == null)
                {
                    _Dresses = new DressesPage();
                }
                return _Dresses;
            }
        }

        public void CustomizeDresses(string Adress, string ExpectedMsg)
        {
            DressesPage.Navigate(Adress);
            DressesPage.MakeSelections();
            DressesPage.AdjustPrice();
            DressesPage.Validate().NoProductsMsg(ExpectedMsg);
        }
    }
}
