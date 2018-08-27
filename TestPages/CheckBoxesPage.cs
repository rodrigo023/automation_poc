using Core;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace TestPages
{
    public class CheckBoxesPage : BasePage
    {
        public CheckBoxesPage(ISession session) : base(session)
        {
        }

        public override void Close()
        {
            Driver.Close();
        }

        //public override void IsPageReady()
        //{
        //    throw new System.NotImplementedException();
        //}

        public List<IWebElement> CheckBoxes => Driver.FindElements(By.XPath("//input[@type='checkbox']")).ToList();

        public override string URL { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        //public Footer Footer; 

        public void ClickCheckBoxByIndex(int index)
        {
            CheckBoxes[index].Click();
        }

        public bool IsCheckboxSelected(int checkbox)
        {
            return CheckBoxes[checkbox].Selected;
        }
    }
}
