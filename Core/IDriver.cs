using OpenQA.Selenium;
using System.Collections.Generic;

namespace Core
{
    internal interface IDriver
    {
        void Launch();
        INavigation Navigate();
        IWebElement FindElement(By by);
        IReadOnlyCollection<IWebElement> FindElements(By by);
        void Close();
        void Quit();
    }
}