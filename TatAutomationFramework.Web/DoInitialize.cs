using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TatAutomationFramework.Web
{
    public class DoInitialize
    {
        private static IWebDriver _driver;

        public static T PageElementsIn<T>() where T : new()
        {
            _driver = TestBase.driver;
            var page = new T();
            PageFactory.InitElements(_driver, page);
            return page;
        }
    }
}
