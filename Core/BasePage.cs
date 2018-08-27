namespace Core
{
    public interface IWebPage
    {
        string Url { get; }
    }

    public abstract class BasePage
    {
        public ISession Session;

        protected Driver Driver;

        public abstract string URL { get; set; }

        public BasePage(ISession session)
        {
            Session = session;

            if(((IHasWebDriver)session).Driver == null)
            {
                ((IHasWebDriver)session).Driver = DriverFactory.GetDriver(Session.DriverSettings);
            }

            Driver = ((IHasWebDriver)session).Driver;
        }

        public abstract void Close();

        //public abstract void IsPageReady();

        public void Go()
        {
            Driver.Navigate().GoToUrl(URL);
        }
       
    }
}
