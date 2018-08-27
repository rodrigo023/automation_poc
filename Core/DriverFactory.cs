using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Core
{
    public static class DriverFactory
    {
        public static Driver GetDriver(DriverSettings settings)
        {
            switch (settings.Browser)
            {
                case Browsers.Chrome:
                    return new Driver(new ChromeDriver());

                case Browsers.Firefox:
                    return new Driver(new FirefoxDriver());

                default:
                    return new Driver(new ChromeDriver());
            }
        }
    }
}
