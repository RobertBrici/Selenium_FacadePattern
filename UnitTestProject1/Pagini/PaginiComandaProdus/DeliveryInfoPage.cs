using UnitTestProject1.Base;
using UnitTestProject1.Date;
using UnitTestProject1.Pagini.PaginaComandaProdus;

namespace UnitTestProject1.Pagini.PaginiComandaProdus
{
    public class DeliveryInfoPage : BasePage<DeliveryInfoPageMap, DeliveryInfoPageValidator>
    {

        public void ClickContinueButton() => Map.ProceedToChekoutBtn.Click();

        public void ClickAddNewAdressButton() => Map.AddANewAdressBtn.Click();

        public void FillNewAdressForm(InfoClient ClientAdress)
        {
            
            Map.FirstNameTextBox.SendKeys(ClientAdress.FirstName);
            Map.LastNameTextBox.SendKeys(ClientAdress.LastName);
            Map.CompanyTextBox.SendKeys(ClientAdress.Company);
            Map.AddressTextBox.SendKeys(ClientAdress.Address);
            Map.CityTextBox.SendKeys(ClientAdress.City);
            Map.StateDropDown.SelectByText(ClientAdress.State);
            Map.ZipPostalCodeTextBox.SendKeys(ClientAdress.PostalCode);
            Map.CountryDropDown.SelectByText(ClientAdress.Country);
            Map.HomePhoneTextBox.SendKeys(ClientAdress.HomePhone);
            Map.MobilePhoneTextBox.SendKeys(ClientAdress.MobilePhone);
            Map.AdditionalInformationTextBox.SendKeys(ClientAdress.AdditionalInformation);
            Map.AddressTitleForFutureReferenceTextBox.SendKeys(ClientAdress.AddressTitleForFutureReference);

            //Map.SwitchToDefault();
        }

        public void SaveNewAdress() => Map.SaveButton.Click();

        public void ContinueToChekout() => Map.ProceedToChekoutButton2.Click();

        public void NavigateToCheckout() => Driver.Browser.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=order");

        public void AproveTermsAndConditions() => Map.AgreeTermsCheckbox.Click();

        public void ContinueToChekout2() => Map.ProceedToChekoutButton3.Click();

        public void PayByBankWire() => Map.PayByBankWireBtn.Click();

        public void OrderConfirmation() => Map.ConfirmOrderBtn.Click();
    }
}
