using UnitTestProject1.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Tests
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void SetupTest() => Driver.StartBrowser(TipBrowser.Chrome, 50);

        [TestCleanup]
        public void TeardownTest() => Driver.StopBrowser();
    }
}
