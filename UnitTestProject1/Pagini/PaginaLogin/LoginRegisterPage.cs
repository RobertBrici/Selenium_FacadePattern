using UnitTestProject1.Base;
using UnitTestProject1.Date;
using OpenQA.Selenium;
using System.Threading;

namespace UnitTestProject1.Pagini.PaginaLogin
{
    public class LogInRegisterPage : BasePage<LoginRegisterPageMap, LoginRegisterPageValidator>
    {
        public LogInRegisterPage() : base(@"http://automationpractice.com/index.php")
        {
            
        }

        private IJavaScriptExecutor jse = Driver.Browser as IJavaScriptExecutor;


        public void ClickSignInSectionButton() => Map.SignInSectionButton.Click();

        public void EnterCredentials(InfoClient Credentials)
        {
            Map.InsertEmailBox.Click();
            Map.InsertEmailBox.SendKeys(Credentials.UserEmail);

            Map.InsertPasswordBox.Click();
            Map.InsertPasswordBox.SendKeys(Credentials.Password);
        }

        public void ClickLoginBtn() => Map.LoginBtn.Click();

        public void SignOut() => Map.SignOutButton.Click();

        //REGISTER PAGE
        public void ClickEmailBox()
        {
            Map.EmailBox.Click();
            Thread.Sleep(2000);
        }

        public void EmailBoxfill(string emailNou)
        {
            Map.EmailBox.SendKeys(emailNou);
            Thread.Sleep(2000);
        }

        public void ClickCreateAccountButton()
        {
            jse.ExecuteScript("window.scrollBy(0, 500);");
            Map.CreateAccountBtn.Click();
        }

        public void FillRegisterForm(InfoClient dateClient)
        {
            Map.GenderCheckBox.Click();
            Map.CustomerFirstNameTextBox.SendKeys(dateClient.FirstName);
            Map.CustomerLastNameTextBox.SendKeys(dateClient.LastName);
            Map.PasswordTextBox.SendKeys(dateClient.Password);
            /*Map.BirthdayDropDown.SelectByText(dateClient.Birthday);
            Map.BirthmonthDropDown.SelectByText(dateClient.Birthmonth);
            Map.BirthyearDropDown.SelectByText(dateClient.Birthyear);*/
            Map.NewsLetterCheckbox.Click();
            Map.OffersCheckbox.Click();
            Map.FirstNameTextBox.SendKeys(dateClient.FirstName);
            Map.LastNameTextBox.SendKeys(dateClient.LastName);
            Map.CompanyTextBox.SendKeys(dateClient.Company);
            Map.AddressTextBox.SendKeys(dateClient.Address);
            Map.CityTextBox.SendKeys(dateClient.City);
            Map.StateDropDown.SelectByText(dateClient.State);
            Map.ZipPostalCodeTextBox.SendKeys(dateClient.PostalCode);
            Map.CountryDropDown.SelectByText(dateClient.Country);
            Map.AdditionalInformationTextBox.SendKeys(dateClient.AdditionalInformation);
            Map.HomePhoneTextBox.SendKeys(dateClient.HomePhone);
            Map.MobilePhoneTextBox.SendKeys(dateClient.MobilePhone);
            Map.AddressTitleForFutureReferenceTextBox.SendKeys(dateClient.AddressTitleForFutureReference);
        }

        public void ClickRegisterButton() => Map.RegisterButton.Click();


    }
}
