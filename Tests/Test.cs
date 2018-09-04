using Core;
using NUnit.Framework;
using TestPages;

namespace Tests
{
    public class Test : WebTest
    {
        public Test(IDriverSettings driverSettings) : base(driverSettings)
        {
        }

        [Test]
        public void Test01()
        {
            var landingPage = Session.GoToPage<LandingPage>();
            var checkBoxPage = landingPage.CheckBoxesLink.Click<CheckBoxesPage>();

            checkBoxPage.Close();
        }
    }
}