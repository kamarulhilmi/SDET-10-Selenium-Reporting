using NUnit.Framework;
using TatAutomationFramework.Web;

namespace TatAutomationFramework.Tests
{
    public class LoginTests : TestBase
    {
        [Test]
        public void Should_DisplayDashBoard_WithCorrectLoginDetails()
        {
            Assert.IsTrue(TatWeb.SideMetaPage
                .NavigateToLogin()
                .LoginWith("admin", "password")
                .GetUser().Contains("admin"));
        }


        [TestCase("admin", " ", "The password field is empty")]
        [TestCase(" ", "password", "The username field is empty")]
        [TestCase("admin", "$%GGH", "The password you entered for the username admin is incorrect")]
        [TestCase("66987", "password", "Invalid username. Lost your password")]

        public void Should_DisplayError_WithInCorrectLoginDetails(string username, string password, string expectedError)
        {
            Assert.IsTrue(TatWeb.SideMetaPage
               .NavigateToLogin()
               .LoginWithAndTestError(username, password)
               .GetMessage().Contains(expectedError));
        }

        [Test]
        public void Should_StayOnLoginPage_WhenNoLoginDetailsAreInputted()
        {
            Assert.IsTrue(TatWeb.SideMetaPage
               .NavigateToLogin()
               .LoginWith()
               .IsAtPage());
        }
    }
}
