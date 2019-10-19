using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Homework.Tests
{
    public class GoogleTests:BaseTest
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private GooglePage _googlePage;

        [SetUp]
        public void TestInit()
        {
            _googlePage = new GooglePage(Driver);

        }

        [Test]
        public void SearchForSelenium()
        {
            _googlePage.Navigate();
            _googlePage.Search("Selenium");
            _googlePage.ClickOnFirstResult();
            _googlePage.AssertDriverTitle("Selenium - Web Browser Automation");
         }
    }
}
