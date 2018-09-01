using NUnit.Framework;
using System.Collections;

namespace Core
{
    public class TestEnvironmentSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestFixtureData(new DriverSettings(Browsers.Chrome));
            yield return new TestFixtureData(new DriverSettings(Browsers.Firefox));
        }
    }
}