namespace UnitTestProject1.Base
{
    public class BasePageValidator<TM> where TM : BasePageElementMap, new()
    {
        protected TM Map
        {
            get
            {
                return new TM();
            }
        }
    }
}
