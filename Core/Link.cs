using OpenQA.Selenium;

namespace Core
{
    public class Link : ILink
    {
        private readonly IWebElement _webElement;
        private readonly IComponentCreator _componentCreator;
        private readonly IDriver _driver;

        public Link(IWebElement webElement, IComponentCreator componentCreator, IDriver driver)
        {
            _webElement = webElement;
            _componentCreator = componentCreator;
            _driver = driver;
        }

        public T Click<T>() where T : IComponent
        {
            _webElement.Click();
            return _componentCreator.Create<T>(_driver);
        }
    }
}
