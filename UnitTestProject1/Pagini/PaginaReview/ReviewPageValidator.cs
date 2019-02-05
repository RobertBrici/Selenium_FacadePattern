using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaReview
{
    public class ReviewPageValidator : BasePageValidator<ReviewPageMap>
    {
        public void ReviewSubmitted(string ExpectedConfirmation)
        {
            Assert.AreEqual<string> (ExpectedConfirmation, Map.ReviewConfirmation.Text);
        }
    }
}
