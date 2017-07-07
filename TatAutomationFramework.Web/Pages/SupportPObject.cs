using OpenQA.Selenium;

namespace TatAutomationFramework.Web.Pages
{
    public class SupportPObject
    {
        IWebDriver driver;

        /// <summary>
        /// Verifies current page
        /// </summary>
        /// <returns></returns>
        public bool IsAtPage()
        {
            driver = TestBase.driver;
            if (driver != null)
            {
                return driver.Title.Contains("Support");
            }
            return false;          
        }
    }
}