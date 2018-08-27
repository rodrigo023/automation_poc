using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace Core
{
    public class Driver : IWebDriver
    {
        private readonly IWebDriver _driver;

        public string Url { get; set; }

        public string Title => _driver.Title;

        public string PageSource => _driver.PageSource;

        public string CurrentWindowHandle => _driver.CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => _driver.WindowHandles;

        public Driver(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Close()
        {
            _driver.Close();
        }

        public void Dispose()
        {
            _driver.Dispose();
        }

        public IWebElement FindElement(By by)
        {
            return _driver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _driver.FindElements(by);
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            return _driver.Navigate();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }
    }
}
