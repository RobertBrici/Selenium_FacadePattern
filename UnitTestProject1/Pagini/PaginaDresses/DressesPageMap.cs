using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace UnitTestProject1.Pagini.PaginaTShirts
{
    public class DressesPageMap : Base.BasePageElementMap
    {

        public IWebElement Category => Browser.FindElement(By.Id("layered_category_11"));

        public IWebElement Size => Browser.FindElement(By.Id("layered_id_attribute_group_3"));

        public IWebElement Color => Browser.FindElement(By.Id("layered_id_attribute_group_16"));

        public IWebElement Compositions => Browser.FindElement(By.Id("layered_id_feature_1"));

        public IWebElement Styles => Browser.FindElement(By.Id("layered_id_feature_13"));

        public IWebElement Properties => Browser.FindElement(By.Id("layered_id_feature_20"));

        public IWebElement LeftPriceSlider => Browser.FindElement(By.CssSelector("#layered_price_slider > a:nth-child(2)"));

        public IWebElement RightPriceSlider => Browser.FindElement(By.CssSelector("#layered_price_slider > a:nth-child(3)"));

        public IWebElement NoProductsMessage
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.CssSelector("#center_column > div.product_list > p")); });
                return Browser.FindElement(By.CssSelector("#center_column > div.product_list > p"));
            }
        }

    }
}
