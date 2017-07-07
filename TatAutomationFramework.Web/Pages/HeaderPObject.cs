using OpenQA.Selenium;

namespace TatAutomationFramework.Web.Pages
{
    public class HeaderPObject
    {
        /// <summary>
        /// Property of the logo element
        /// </summary>
        protected IWebElement Logo { get; set; }

        /// <summary>
        /// Property of the tagline element
        /// </summary>
        protected IWebElement Tagline { get; set; }
                
        /// <summary>
        /// Method Check logo is displayed
        /// </summary>
        /// <returns>bool</returns>
        public bool IsLogoDisplayed()
        {
            Logo = TestBase.driver.FindElement(By.Id("site-title"));
            return Logo.Displayed;
        }

        /// <summary>
        /// Method Check Tagline is Correct
        /// </summary>
        /// <returns>string</returns>
        public string IsTaglineCorrect()
        {
            Tagline = TestBase.driver.FindElement(By.Id("site-description"));
            return Tagline.Text;
        }
    }
}
