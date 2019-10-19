using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;


namespace Homework.Pages
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => _wait;

        public virtual void Navigate(string url)
        {
            Driver.Url = url;
        }

        public void AssertUrl(String expectedUrl)
        {
            Assert.AreEqual(expectedUrl, Driver.Url);
        }

        public void AssertDriverTitle(String expectedTitle)
        {
            Assert.AreEqual(expectedTitle, Driver.Title);
        }

        public void AssertElementDisplayed(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertElementText(IWebElement element, String expectedText)
        {
            Assert.AreEqual(expectedText, element.Text);
        }
    }
}
