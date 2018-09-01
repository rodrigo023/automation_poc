using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

namespace Core
{
    internal class Driver : IDriver
    {
        private readonly IDriverSettings _driverSettings;
        private IWebDriver _driver;
        public string Url { get; set; }
        public string Title => _driver.Title;
        public string PageSource => _driver.PageSource;
        public string CurrentWindowHandle => _driver.CurrentWindowHandle;
        public IReadOnlyCollection<string> WindowHandles => _driver.WindowHandles;
        public IComponentCreator ComponentCreator { get; }

        public Driver(IDriverSettings driverSettings, IComponentCreator componentCreator)
        {
            _driverSettings = driverSettings;
            ComponentCreator = componentCreator;
        }

        public void Launch()
        {
            switch (_driverSettings.Browser)
            {
                case Browsers.Firefox:
                    _driver = new FirefoxDriver();
                    break;
                default:
                    _driver = new ChromeDriver();
                    break;
            }
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

        public IReadOnlyCollection<IWebElement> FindElements(By by)
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
            _driver.Quit();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }

        public T CreatePage<T>() where T : IComponent
        {
            return ComponentCreator.Create<T>(this);
        }
    }
}