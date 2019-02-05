using UnitTestProject1.Date;
using UnitTestProject1.Pagini.PaginaLogin;
using UnitTestProject1.Pagini.PaginaProdus;
using UnitTestProject1.Pagini.PaginiComandaProdus;

namespace UnitTestProject1
{
    class OrderProductFacade
    {
        private ItemPage _Product;
        private DeliveryInfoPage _DeliveryData;
        private LogInRegisterPage _LogIn;

        public ItemPage ItemPage
        {
            get
            {
                if (_Product == null)
                {
                    _Product = new ItemPage();
                }
                return _Product;
            }
        }

        public LogInRegisterPage LogInPage
        {
            get
            {
                if (_LogIn == null)
                {
                    _LogIn = new LogInRegisterPage();
                }
                return _LogIn;
            }
        }

        public DeliveryInfoPage DeliveryInfoPage
        {
            get
            {
                if (_DeliveryData == null)
                {
                    _DeliveryData = new DeliveryInfoPage();
                }
                return _DeliveryData;
            }
        }

        public void CumparareProdus(string produs, string pretProdus, string pret2Buc, string pretTotal, InfoClient dateleClientului, InfoClient credentials, string ExpectedConfirmationMsg)
        {
            ItemPage.Navigate(produs);
            ItemPage.Validate().Price(pretProdus);
            ItemPage.IncreaseQuantity();
            ItemPage.ChangeSize();
            ItemPage.ChangeColor();
            //ItemPage.Validate().PriceFor2Buc(pret2Buc);
            ItemPage.ClickAddToCart();
            ItemPage.ProceedToChekout();
            DeliveryInfoPage.ClickContinueButton();
            LogInPage.EnterCredentials(credentials);
            LogInPage.ClickLoginBtn();
            DeliveryInfoPage.ClickAddNewAdressButton();
            DeliveryInfoPage.FillNewAdressForm(dateleClientului);
            DeliveryInfoPage.SaveNewAdress();
            DeliveryInfoPage.ContinueToChekout();
            DeliveryInfoPage.AproveTermsAndConditions();
            DeliveryInfoPage.ContinueToChekout2();
            DeliveryInfoPage.Validate().Subtotal(pretTotal);
            DeliveryInfoPage.PayByBankWire();
            DeliveryInfoPage.OrderConfirmation();   
            DeliveryInfoPage.Validate().SentOrderConfirmation(ExpectedConfirmationMsg);
        }
    }
}
