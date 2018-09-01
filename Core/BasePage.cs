namespace Core
{
    public abstract class WebPage : INavigableComponent
    {
        internal IDriver Driver { get; }

        internal WebPage(IDriver driver)
        {
            Driver = driver;
        }

        public abstract string Url { get; }

        public abstract void Close();

        public void GoToUrl()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        //public abstract void IsPageReady();
    }
}