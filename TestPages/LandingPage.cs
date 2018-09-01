using Core;
using OpenQA.Selenium;

namespace TestPages
{
    public class LandingPage : WebPage
    {
        public LandingPage(IDriver driver) : base(driver)
        {
        }

        public IWebElement CheckBoxesLink => Driver.FindElement(By.XPath("//a[contains(@href,'/checkboxes')]"));

        public override string Url { get => "https://the-internet.herokuapp.com/"; }

        public override void Close()
        {
            Driver.Close();
        }

        //public override void IsPageReady()
        //{
        //    throw new NotImplementedException();
        //}

        public CheckBoxesPage NavigateToCheckboxesPage()
        {
            CheckBoxesLink.Click();
            return Driver.CreatePage<CheckBoxesPage>();
        }
    }
}