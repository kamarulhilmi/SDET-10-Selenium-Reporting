using NUnit.Framework;
using TatAutomationFramework.Web;

namespace TatAutomationFramework.Tests
{
    public class NavigationTests : TestBase
    {
        [Test]
        public void Should_NavigateToNewsPage_WhenLinkIsSelected()
        {
            Assert.IsFalse(TatWeb.MenuPage
                .NavigateToNews()
                .IsAtPage(), "You are not on the News page");
        }
        
        [Test]
        public void Should_NavigateToSupportPage_WhenLinkIsSelected()
        {
            Assert.That(TatWeb.MenuPage
                .NavigateToSupport()
                .IsAtPage(), "You are not on the Support page");
        }


        [Test]
        public void Should_NavigateToHomePage_WhenLinkIsSelected()
        {
            Assert.That(TatWeb.MenuPage
                .NavigateToHome()
                .IsAtPage(), "You are not on the home page");
        }
    }
}
