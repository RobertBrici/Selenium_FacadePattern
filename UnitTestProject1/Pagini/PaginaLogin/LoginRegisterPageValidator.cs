using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaLogin
{
    public class LoginRegisterPageValidator : BasePageValidator<LoginRegisterPageMap>
    {
        public void SuccesLogin(string expectedSign)
        {
            Assert.AreEqual<string>(expectedSign, Map.VerifiyLoginSuccess.Text);
        }

        public void SuccessfulLogout(string expectedSection)
        {
            Assert.AreEqual<string>(expectedSection, Map.VerifyLogoutSuccess.Text);
        }

        public void SuccessfulRegister(string expectedWelcome)
        {
            Assert.AreEqual<string>(expectedWelcome, Map.AfterRegisterMsg.Text);
        }

        public void DeniedLogin(string expectedDenialMsg)
        {
            Assert.AreEqual<string>(expectedDenialMsg, Map.DeniedLoginMsg.Text);
        }

        public void DeniedRegister(string expectedDenialMsg)
        {
            Assert.AreEqual<string>(expectedDenialMsg, Map.DeniedRegisterMsg.Text);
        }
    }
}
