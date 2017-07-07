using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class DashBoardHeaderPObject
    {
        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-my-account .ab-item")]
        protected IWebElement UserNameTxt { get; set; }

        /// <summary>
        /// Get Displayed User Name 
        /// </summary>
        /// <returns></returns>
        public string GetUser()
        {
            return UserNameTxt.Text;
        }
    }
}