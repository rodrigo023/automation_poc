using OpenQA.Selenium;

namespace Core
{
    internal interface IDriverSettings
    {
        Browsers Browser { get; }

        PlatformType PlatformType { get; }
    }
}