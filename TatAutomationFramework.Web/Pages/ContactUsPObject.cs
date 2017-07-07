using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class ContactUsPObject
    {
        [FindsBy(How = How.CssSelector, Using = ".entry-title")]
        protected IWebElement PageHeaderTitle { get; set; }


        /// <summary>
        /// Verifies current page
        /// </summary>
        /// <returns></returns>
        public bool IsAtPage()
        {
            return PageHeaderTitle.Text.Contains("Contact");
        }

    }
}