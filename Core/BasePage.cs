namespace Core
{
    public interface IWebPage
    {
        string Url { get; }
    }

    public abstract class BasePage : IComponent
    {
        protected IDriver Driver { get; set; }

        protected BasePage()
        {
        }

        internal BasePage(IDriver driver)
        {
            Driver = driver;
        }

        public abstract string Url { get; set; }

        public abstract void Close();

        //public abstract void IsPageReady();

        public void Go()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        protected T GoToPage<T>() where T: IComponent, new()
        {
            var page = new T();
            SetDriver(page);

            return page;
        }

        private void SetDriver(IComponent page)
        {
            (page as BasePage).Driver = Driver;
        }
    }
}