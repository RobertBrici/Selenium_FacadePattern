using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.Pagini.PaginaLogin
{

    public class LoginRegisterPageMap : Base.BasePageElementMap
    {
        public IWebElement SignInSectionButton => Browser.FindElement(By.XPath(".//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

        public IWebElement InsertEmailBox => Browser.FindElement(By.XPath(".//*[@id='email']"));

        public IWebElement InsertPasswordBox => Browser.FindElement(By.XPath(".//*[@id='passwd']"));

        public IWebElement LoginBtn => Browser.FindElement(By.XPath(".//*[@id='SubmitLogin']"));

        public IWebElement VerifiyLoginSuccess
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p")); });
                return (Browser.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p")));
            }
        }

        public IWebElement SignOutButton => Browser.FindElement(By.ClassName("logout"));

        public IWebElement VerifyLogoutSuccess => Browser.FindElement(By.CssSelector("#login_form > h3"));

        //REGISTER PAGE
        public IWebElement EmailBox => Browser.FindElement(By.CssSelector("#email_create"));

        public IWebElement CreateAccountBtn => Browser.FindElement(By.Id("SubmitCreate"));

        public IWebElement GenderCheckBox
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Id("id_gender1")); });
                return (Browser.FindElement(By.Id("id_gender1")));
            }
        }

        public IWebElement CustomerFirstNameTextBox => Browser.FindElement(By.Id("customer_firstname"));

        public IWebElement CustomerLastNameTextBox => Browser.FindElement(By.Id("customer_lastname"));

        public IWebElement PasswordTextBox => Browser.FindElement(By.Id("passwd"));

        public SelectElement BirthdayDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Id("days")); });
                return new SelectElement(Browser.FindElement(By.Id("days")));
            }
        }

        public SelectElement BirthmonthDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("months")); });
                return new SelectElement(Browser.FindElement(By.Name("months")));
            }
        }

        public SelectElement BirthyearDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("years")); });
                return new SelectElement(Browser.FindElement(By.Name("years")));
            }
        }

        public IWebElement NewsLetterCheckbox => Browser.FindElement(By.Id("newsletter"));

        public IWebElement OffersCheckbox => Browser.FindElement(By.Id("optin"));

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

        public IWebElement RegisterButton => Browser.FindElement(By.Id("submitAccount"));

        public IWebElement AfterRegisterMsg => Browser.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p"));

        public IWebElement DeniedLoginMsg => Browser.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));

        public IWebElement DeniedRegisterMsg
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.CssSelector("#create_account_error > ol > li")); });
                return Browser.FindElement(By.CssSelector("#create_account_error > ol > li"));
            }
        }
    }
}
