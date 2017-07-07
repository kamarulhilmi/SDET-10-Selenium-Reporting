using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class HeaderPObjectTwo
    {        
        

        /// <summary>
        /// Property of the logo element
        /// </summary>
        [FindsBy(How = How.Id, Using = "site-title")]
        protected IWebElement Logo { get; set; }

        /// <summary>
        /// Property of the logo element
        /// </summary>
        [FindsBy(How = How.Id, Using = "site-description")]
        protected IWebElement Tagline { get; set; }

        /// <summary>
        /// Method Check logo is displayed
        /// </summary>
        /// <returns>bool</returns>
        public bool IsLogoDisplayed()
        {
           return Logo.Displayed;
        }

        /// <summary>
        /// Method Check Tagline is Correct
        /// </summary>
        /// <returns>string</returns>
        public string IsTaglineCorrect()
        {            
            return Tagline.Text;
        }
    }
}
