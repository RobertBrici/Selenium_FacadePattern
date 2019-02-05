using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaProdus
{
    public class ItemPageMap : BasePageElementMap
    {
        public IWebElement AddToCartButton => Browser.FindElement(By.Id("add_to_cart"));

        public IWebElement DisplayedPrice => Browser.FindElement(By.Id("our_price_display"));

        public IWebElement IncreaseQuantity => Browser.FindElement(By.CssSelector("#quantity_wanted_p > a.btn.btn-default.button-plus.product_quantity_up > span"));

        public IWebElement ChangeColor => Browser.FindElement(By.Id("color_14"));

        public SelectElement SizeDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("group_1")); });
                return new SelectElement(Browser.FindElement(By.Name("group_1")));
            }
        }

        
    }
}
