using OpenQA.Selenium;

namespace Core
{
    public interface IDriverSettings
    {
        Browsers Browser { get; }

        PlatformType PlatformType { get; }
    }
}