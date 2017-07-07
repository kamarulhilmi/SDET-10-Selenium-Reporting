using NUnit.Framework;
using TatAutomationFramework.Web;


namespace TatAutomationFramework.Tests
{
    [SetUpFixture]
    public class TestSetup
    {
        /// <summary>
        /// Run Method Only Once before tests
        /// </summary>
        [OneTimeSetUp]
        public void Start()
        {
          TestBase.BeginExecution();
        }
        /// <summary>
        /// Run Method Only Once After tests
        /// </summary>
        [OneTimeTearDown]
        public void End()
        {
           TestBase.ExitExecution();
        }
    }
}
