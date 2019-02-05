namespace UnitTestProject1.Base
{
    public class BasePage<TM> where TM : BasePageElementMap, new()
    {
        protected readonly string _Url;

        public BasePage(string Url)
        {
            _Url = Url;
        }

        public BasePage()
        {
            _Url = null;
        }

        protected TM Map
        {
            get
            {
                return new TM();
            }
        }

        public virtual void Navigate(string Link = "")
        {
            Driver.Browser.Navigate().GoToUrl(string.Concat(_Url, Link));
        }
    }

    public class BasePage<TM, TV> : BasePage<TM>
        where TM : BasePageElementMap, new()
        where TV : BasePageValidator<TM>, new()
    {
        public BasePage(string Url) : base(Url)
        {
        }

        public BasePage(){}

        public TV Validate()
        {
            return new TV();
        }
    }
}
