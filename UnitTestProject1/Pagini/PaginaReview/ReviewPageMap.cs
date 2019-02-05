using OpenQA.Selenium;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaReview
{
    public class ReviewPageMap : BasePageElementMap
    {
        public IWebElement CreateReviewBtn => Browser.FindElement(By.CssSelector("#new_comment_tab_btn > span"));

        public IWebElement CommentTitle => Browser.FindElement(By.CssSelector("#comment_title"));

        public IWebElement Comment => Browser.FindElement(By.Name("content"));

        public IWebElement Star => Browser.FindElement(By.CssSelector("# criterions_list > li > div.star_content > div:nth-child(4)"));

        public IWebElement SendReviewBtn => Browser.FindElement(By.Id("submitNewMessage"));

        public IWebElement SentConfirmation => Browser.FindElement(By.CssSelector("# product > div.fancybox-wrap.fancybox-desktop.fancybox-type-html.fancybox-opened > div > div > div > p:nth-child(2)"));

        public IWebElement ReviewConfirmation => Browser.FindElement(By.CssSelector("#product > div.fancybox-wrap.fancybox-desktop.fancybox-type-html.fancybox-opened > div > div > div > p:nth-child(2)"));

        public IWebElement Body => Browser.FindElement(By.Id("product"));

    }
}
