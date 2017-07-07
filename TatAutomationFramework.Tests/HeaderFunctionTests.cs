using NUnit.Framework;
using TatAutomationFramework.Web;

namespace TatAutomationFramework.Tests
{
    public class HeaderFunctionTests : TestBase
    {

        [Test]
        public void Should_DisplayLogo_WhenUserNavigatesToSite()
        {
            Assert.That(TatWeb.HeaderPage.IsLogoDisplayed(), "Logo is not Displayed");
        }

        [Test]
        public void Should_DisplayCorrectTagline_WhenUserNavigatesToSite()
        {
            Assert.That(TatWeb.HeaderPage
                .IsTaglineCorrect()
                .Equals("Your Local WordPress Installation"), "TagLine is incorrect");
        }
    }
}
