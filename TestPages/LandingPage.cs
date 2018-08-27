using Core;
using OpenQA.Selenium;
using System;

namespace TestPages
{
    public class LandingPage : BasePage
    {
        public LandingPage(ISession session) : base(session)
        {
        }

        public IWebElement CheckBoxesLink => Driver.FindElement(By.XPath("//a[contains(@href,'/checkboxes')]"));

        public override string URL { get => "https://the-internet.herokuapp.com/"; set => throw new NotImplementedException(); }

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
            return new CheckBoxesPage(Session);

        }
    }
}
