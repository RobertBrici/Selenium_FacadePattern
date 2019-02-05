using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaContact
{
    class ContactPageMap : Base.BasePageElementMap
    {

        public SelectElement SubjectHeadingDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("id_contact")); });
                return new SelectElement(Browser.FindElement(By.Name("id_contact")));
            }
        }

        public IWebElement EmailBox => Browser.FindElement(By.Id("email"));

        public IWebElement OrderReferenceBox => Browser.FindElement(By.Id("id_order"));

        public IWebElement MessageBox => Browser.FindElement(By.Id("message"));

        public IWebElement FormSendButton => Browser.FindElement(By.CssSelector("#submitMessage > span"));

        public IWebElement ConfirmationMessage => Browser.FindElement(By.CssSelector("#center_column > p"));
    }
}
