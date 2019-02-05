using UnitTestProject1.Date;
using UnitTestProject1.Pagini.PaginaLogin;
using UnitTestProject1.Pagini.PaginaReview;

namespace UnitTestProject1
{
    class ReviewFacade
    {

        private ReviewPage _Review;
        private LogInRegisterPage _LogIn;

        public ReviewPage ReviewPage
        {
            get
            {
                if (_Review == null)
                {
                    _Review = new ReviewPage();
                }
                return _Review;
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

        public void CreateReview(string Adress, string Title, string Comment, InfoClient Credentials, string ExpectedConfirmation)
        {
            LogInPage.Navigate("");
            LogInPage.ClickSignInSectionButton();
            LogInPage.EnterCredentials(Credentials);
            LogInPage.ClickLoginBtn();
            ReviewPage.Navigate(Adress);
            ReviewPage.ScrollDown();
            ReviewPage.ClickToAddReview();
            ReviewPage.EnterCommentTitle(Title);
            ReviewPage.EnterComment(Comment);
            //ReviewPage.RateStar();
            ReviewPage.SendReview();
            ReviewPage.ClickOk();
            ReviewPage.Validate().ReviewSubmitted(ExpectedConfirmation);
        }
        
    }
}
