using System.Threading;
using UnitTestProject1.Base;


namespace UnitTestProject1.Pagini.PaginaProdus
{
    public class ItemPage : BasePage<ItemPageMap, ItemPageValidator>
    {
        public ItemPage() : base("http://automationpractice.com/index.php")
        {

        }

        public void IncreaseQuantity() => Map.IncreaseQuantity.Click();

        public void ChangeSize() => Map.SizeDropDown.SelectByValue("2");

        public void ChangeColor() => Map.ChangeColor.Click();

        public void ClickAddToCart() => Map.AddToCartButton.Click();

        public void ProceedToChekout()
        {
            Thread.Sleep(2000);
            Driver.Browser.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=order");
        }
    }
}
