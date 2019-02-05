using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginiComandaProdus
{
    public class DeliveryInfoPageMap : BasePageElementMap
    {
        public IWebElement ProceedToChekoutBtn
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span")); });
                return Browser.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span"));
            }
        }

        public IWebElement AddANewAdressBtn => Browser.FindElement(By.CssSelector("#center_column > form > div > p > a > span"));

        public IWebElement FirstNameTextBox => Browser.FindElement(By.Id("firstname"));

        public IWebElement LastNameTextBox => Browser.FindElement(By.Id("lastname"));

        public IWebElement CompanyTextBox => Browser.FindElement(By.Id("company"));

        public IWebElement AddressTextBox => Browser.FindElement(By.Id("address1"));

        public IWebElement CityTextBox => Browser.FindElement(By.Id("city"));

        public SelectElement StateDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("id_state")); });
                return new SelectElement(Browser.FindElement(By.Name("id_state")));
            }
        }

        public IWebElement ZipPostalCodeTextBox => Browser.FindElement(By.Id("postcode"));

        public SelectElement CountryDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("id_country")); });
                return new SelectElement(Browser.FindElement(By.Name("id_country")));
            }
        }

        public IWebElement HomePhoneTextBox => Browser.FindElement(By.Id("phone"));

        public IWebElement MobilePhoneTextBox => Browser.FindElement(By.Id("phone"));

        public IWebElement AdditionalInformationTextBox => Browser.FindElement(By.Id("other"));

        public IWebElement AddressTitleForFutureReferenceTextBox => Browser.FindElement(By.Id("alias"));

        public IWebElement SaveButton => Browser.FindElement(By.CssSelector("#submitAddress > span"));

        public IWebElement ProceedToChekoutButton2 => Browser.FindElement(By.CssSelector("#center_column > form > p > button > span"));

        public IWebElement AgreeTermsCheckbox => Browser.FindElement(By.Id("cgv"));

        public IWebElement ProceedToChekoutButton3 => Browser.FindElement(By.CssSelector("#form > p > button > span"));

        public IWebElement TotalPrice => Browser.FindElement(By.Id("total_price"));

        public IWebElement PayByBankWireBtn => Browser.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(1) > div > p > a"));

        public IWebElement ConfirmOrderBtn => Browser.FindElement(By.CssSelector("#cart_navigation > button > span"));

        public IWebElement OrderConfirmation => Browser.FindElement(By.CssSelector("#center_column > div > p > strong"));

    }


}
