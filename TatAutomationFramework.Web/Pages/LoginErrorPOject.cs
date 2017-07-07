using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class LoginErrorPOject
    {
        [FindsBy(How = How.Id, Using = "login_error")]
        protected IWebElement ErrorTxt { get; set; }

        /// <summary>
        /// Get Displayed Error Message 
        /// </summary>
        /// <returns></returns>
        public string GetMessage()
        {
            return ErrorTxt.Text;
        }
    }
}