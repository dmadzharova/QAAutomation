using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Homework.Tests
{
    public class RegistrationPageTests : BaseTest
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private LoginPage _loginPage;
        private APHomePage _homePage;

        [SetUp]
        public void TestInit()
        {
            _loginPage = new LoginPage(Driver);
            _homePage = new APHomePage(Driver);

        }

        [Test]
        public void SignIn()
        {
            _homePage.Navigate();
            _homePage.SignIn();

            _loginPage.AssertUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }
    }
}
