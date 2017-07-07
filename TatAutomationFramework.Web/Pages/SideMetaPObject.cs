using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class SideMetaPObject
    {
        [FindsBy(How = How.PartialLinkText, Using = "Log in")]
        protected IWebElement LoginLink { get; set; }
        
        /// <summary>
        /// Navigate to login Page
        /// </summary>
        /// <returns></returns>
        public WpLoginPObject NavigateToLogin()
        {
            LoginLink.Click();
            return DoInitialize.PageElementsIn<WpLoginPObject>();
        }
    }
}
