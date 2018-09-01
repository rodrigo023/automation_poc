namespace Core
{
    internal class Session : ISession
    {
        private IDriver _driver;

        internal Session(IDriver driver)
        {
            _driver = driver;
        }

        public T GoToPage<T>() where T: INavigableComponent
        {
            var page = _driver.CreatePage<T>();
            page.GoToUrl();

            return page;
        }
    }
}