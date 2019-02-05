using OpenQA.Selenium;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaReview
{
    public class ReviewPage : BasePage<ReviewPageMap, ReviewPageValidator>
    {

        private IJavaScriptExecutor jse = Driver.Browser as IJavaScriptExecutor;

        public ReviewPage() : base("http://automationpractice.com/index.php")
        {

        }   

        public void ScrollDown() => jse.ExecuteScript("window.scrollBy(0, 1000);");

        public void ClickToAddReview() => Map.CreateReviewBtn.Click();

        public void EnterCommentTitle(string Title) => Map.CommentTitle.SendKeys(Title);

        public void EnterComment(string Comment) => Map.Comment.SendKeys(Comment);

        public void RateStar() => Map.Star.Click();

        public void SendReview() => Map.SendReviewBtn.Click();

        public void ClickOk() => Map.Body.Click();
    }
}
