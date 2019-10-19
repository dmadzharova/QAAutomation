using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace Homework.Pages
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void InitializeTests()
        {
            //Config for SeleniumGrid
            ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";

            Driver = new RemoteWebDriver(new Uri("http://192.168.1.103:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);

            //Config for local run on Chrome
            //Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
