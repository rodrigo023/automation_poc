using System;
using OpenQA.Selenium;

namespace Core
{
    public class WebElementFactory
    {
        private readonly IDriver _driver;
        private readonly IComponentCreator _componentCreator;

        public WebElementFactory(IDriver driver, IComponentCreator componentCreator)
        {
            _driver = driver;
            _componentCreator = componentCreator;
        }

        public T Create<T>(By finder) where T : ICustomElement
        {
            var webElement = _driver.FindElement(finder);

            switch (typeof(T).Name)
            {
                case "Link":
                    ICustomElement customElement = new Link(webElement, _componentCreator, _driver);
                    return (T)customElement;
                default:
                    throw new Exception($"Element {typeof(T).Name} not found");
            }
        }
    }
}