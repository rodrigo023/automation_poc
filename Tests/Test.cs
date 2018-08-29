using Core;
using NUnit.Framework;
using TestPages;

namespace Tests
{
    [TestFixture]
    public class Test : TestBase
    {
        [Test]
        public void Test01()
        {
            var landingPage = Session.CreatePage<LandingPage>();
            landingPage.Go();

            var checkBoxPage = landingPage.NavigateToCheckboxesPage();
            
            checkBoxPage.Close();
        }
    }
}