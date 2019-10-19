using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Homework.Pages;
using Hamework.Pages;

namespace Homework.Tests
{
    public class SoftUniTests : BaseTest
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private SoftUniPage _softuniPage;
        private QATrainingPage _qaTrainingPage;


        [SetUp]
        public void TestInit()
        {
            _softuniPage = new SoftUniPage(Driver);
            _qaTrainingPage = new QATrainingPage(Driver);

        }

        [Test]
        public void SearchForQACourse()
        {
            _softuniPage.Navigate();
            _softuniPage.FindQACourse();

            _qaTrainingPage.AssertElementDisplayed(_qaTrainingPage.HeadingTag);
            _qaTrainingPage.AssertElementText(_qaTrainingPage.HeadingTag, "QA Automation - септември 2019");
        }
    }
}