using UnitTestProject1.Date;
using UnitTestProject1.Pagini.PaginaLogin;

namespace UnitTestProject1
{
    class LoginRegisterFacade
    {
        private LogInRegisterPage _LogIn;

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


        public void LoginAndOut(string Adress, string LoginConfirmationMsg, string LogoutConfirmationMsg, InfoClient Credentials)
        {
            LogInPage.Navigate(Adress);
            LogInPage.EnterCredentials(Credentials);
            LogInPage.ClickLoginBtn();
            LogInPage.Validate().SuccesLogin(LoginConfirmationMsg);
            LogInPage.SignOut();
            LogInPage.Validate().SuccessfulLogout(LogoutConfirmationMsg);
        }

        public void RegisterAccount(string Adress, InfoClient ClientInfo, string Welcome, OtherInfo RandomEmail)
        {
            LogInPage.Navigate(Adress);
            LogInPage.ClickEmailBox(); 
            LogInPage.EmailBoxfill(RandomEmail.Email);
            LogInPage.ClickCreateAccountButton();
            LogInPage.FillRegisterForm(ClientInfo);
            LogInPage.ClickRegisterButton();
            LogInPage.Validate().SuccessfulRegister(Welcome);
        }

        public void LoginWrongPassword(string Adress, string LoginDenialMsg, InfoClient Credentials)
        {
            LogInPage.Navigate(Adress);
            LogInPage.EnterCredentials(Credentials);
            LogInPage.ClickLoginBtn();
            LogInPage.Validate().DeniedLogin(LoginDenialMsg);
        }

        public void RegisterAlreadyUsedMail(string Adress, string RegisterDenialMsg, OtherInfo WrongEmail)
        {
            LogInPage.Navigate(Adress);
            LogInPage.ClickEmailBox();
            LogInPage.EmailBoxfill(WrongEmail.Email);
            LogInPage.ClickCreateAccountButton();
            LogInPage.Validate().DeniedRegister(RegisterDenialMsg);
        }
    }
}
