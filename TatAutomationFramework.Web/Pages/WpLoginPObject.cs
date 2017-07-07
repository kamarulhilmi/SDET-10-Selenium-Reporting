using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class WpLoginPObject
    {
        [FindsBy(How = How.Id, Using = "user_login")]
        protected IWebElement UsernameTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "user_pass")]
        protected IWebElement PasswordTxtBox { get; set; }

        [FindsBy(How = How.Id, Using = "wp-submit")]
        protected IWebElement LoginBtn { get; set; }
        
        /// <summary>
        /// Checks If we are on the correct page
        /// empty credentials
        /// </summary>
        /// <returns></returns>
        public bool IsAtPage()
        {
            return LoginBtn.Displayed;
        }
        
        /// <summary>
        /// Login to check it stays on same page and no error with
        /// empty credentials
        /// </summary>
        /// <returns></returns>
        public WpLoginPObject LoginWith()
        {
            LoginBtn.Click();
            return this;
        }

        /// <summary>
        /// Successful login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DashBoardHeaderPObject LoginWith(string username, string password)
        {
            PerformLogin(username, password);
            return DoInitialize.PageElementsIn<DashBoardHeaderPObject>();
        }

        /// <summary>
        /// Login to test error page shows up
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginErrorPOject LoginWithAndTestError(string username, string password)
        {
            PerformLogin(username, password);
            return DoInitialize.PageElementsIn<LoginErrorPOject>();
        }

        /// <summary>
        /// Perform Login actions
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void PerformLogin(string username, string password)
        {
            UsernameTxtBox.SendKeys(username);
            PasswordTxtBox.SendKeys(password);
            LoginBtn.Click();
        }

    }
}