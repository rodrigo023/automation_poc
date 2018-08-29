using OpenQA.Selenium;

namespace Core
{
    internal class DriverSettings : IDriverSettings
    {
        public Browsers Browser { get; }

        public PlatformType PlatformType { get; }

        public DriverSettings(Browsers browser, PlatformType platformType)
        {
            Browser = browser;
            PlatformType = platformType;
        }

        public DriverSettings(Browsers browser)
        {
            Browser = browser;
        }
    }
}