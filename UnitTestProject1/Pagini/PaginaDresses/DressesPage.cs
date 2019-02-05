using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using UnitTestProject1.Base;

namespace UnitTestProject1.Pagini.PaginaTShirts
{
    public class DressesPage : BasePage<DressesPageMap, DressesPageValidator>
    {
        public DressesPage() : base("http://automationpractice.com/index.php")
        {

        }

        private IJavaScriptExecutor jse = Driver.Browser as IJavaScriptExecutor;
        private Actions prc = new Actions(Driver.Browser);

        public void MakeSelections()
        {
            Map.Category.Click();
            Map.Size.Click();
            Map.Color.Click();
            Map.Styles.Click();
            Map.Properties.Click();
        }

        public void AdjustPrice()
        {
            jse.ExecuteScript("window.scrollBy(0, 400);"); 
            prc.DragAndDrop(Map.RightPriceSlider, Map.LeftPriceSlider);
            prc.Build().Perform();
        }


    }
}
