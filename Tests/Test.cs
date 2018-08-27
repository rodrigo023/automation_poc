using Core;

using NUnit.Framework;
using System.Threading;
using TestPages;

namespace Tests
{
    [TestFixture]
    public class Test : TestBase
    {
        [Test]
        public void Test01()
        {
            var landingPage = new LandingPage(Session);
            landingPage.Go();

            var checkBoxPage = landingPage.NavigateToCheckboxesPage();

            Thread.Sleep(5000);

            checkBoxPage.Close();
        }
    }
}
