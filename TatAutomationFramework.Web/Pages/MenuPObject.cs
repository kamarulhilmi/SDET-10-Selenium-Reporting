using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web.Pages
{
    public class MenuPObject
    {
        [FindsBy(How = How.PartialLinkText, Using = "Home")]
        protected IWebElement Home { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "About")]
        protected IWebElement About { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Contact Us")]
        protected IWebElement ContactUs { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Links")]
        protected IWebElement Links { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Sample Page")]
        protected IWebElement SamplePage { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "News")]
        protected IWebElement News { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Support")]
        protected IWebElement Support { get; set; }

        
        public HomePObject NavigateToHome()
        {
            Home.Click();
            return DoInitialize.PageElementsIn<HomePObject>();
        }

        public AboutPObject NavigateToAbout()
        {
            About.Click();
            return DoInitialize.PageElementsIn<AboutPObject>();
        }

        public ContactUsPObject NavigateToContactUs()
        {
            ContactUs.Click();
            return DoInitialize.PageElementsIn<ContactUsPObject>();
        }


        public LinksPObject NavigateToLinks()
        {
            Links.Click();
            return DoInitialize.PageElementsIn<LinksPObject>();
        }

        public SamplePObject NavigateToSamplePage()
        {
            SamplePage.Click();
            return DoInitialize.PageElementsIn<SamplePObject>();
        }

        public NewsPObject NavigateToNews()
        {
            News.Click();
            return DoInitialize.PageElementsIn<NewsPObject>();
        }

        public SupportPObject NavigateToSupport()
        {
            Support.Click();
            return DoInitialize.PageElementsIn<SupportPObject>();
        }
    }
}
