using OpenQA.Selenium;
using System.Collections.Generic;

namespace Core
{
    public interface IDriver
    {
        void Launch();
        void Close();
        void Quit();
        T CreatePage<T>() where T : IComponent;
        INavigation Navigate();
        IWebElement FindElement(By by);
        IReadOnlyCollection<IWebElement> FindElements(By by);
        T CreateElement<T>(By finder) where T : ICustomElement;
    }
}