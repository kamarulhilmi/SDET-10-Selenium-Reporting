using System;
using NUnit.Framework;
using TatAutomationFramework.Common;
using RelevantCodes.ExtentReports;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TatAutomationFramework.Web
{
    /// <summary>
    /// This attribute that marks a class that contains tests 
    /// and is inherited by any derived classes
    /// This means we do not have to worry about this in our test classes
    /// </summary>
    [TestFixture]
    public abstract class TestBase
    {
        public static IWebDriver driver;
        public static ReportingTasks _reportingTasks;
    
        ///<summary>
        ///Run Before every Test and setup Tests.
        ///</summary>
        [SetUp]
        public void TestSetup()
        {
            _reportingTasks.InitializeTest();
            driver.Navigate().GoToUrl("http://127.0.0.1:4001/wordpress/");
        }
        /// <summary>
        /// Runs after every Test and Cleans up Test.
        /// </summary>
        [TearDown]
        public void TestCleanUp()
        {
            _reportingTasks.FinalizeTest();
            driver.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// Begin execution of tests
        /// </summary>
        public static void BeginExecution()
        {
            ExtentReports extentReports = ReportingManager.Instance;
            extentReports.LoadConfig(Directory.GetParent(TestContext.CurrentContext.TestDirectory).Parent.FullName + "\\extent-config.xml");            
            //Note we have hardcoded the browser, we will deal with this later
            extentReports.AddSystemInfo("Browser", "Chrome");

            _reportingTasks = new ReportingTasks(extentReports);


            driver = new ChromeDriver(@"C:\library");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Finish Execution of tests
        /// </summary>
        public static void ExitExecution()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            _reportingTasks.CleanUpReporting();
        }
    }
}

