using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Homework.Extensions;

namespace Homework.Pages
{
    public class GooglePage:BasePage
    {
        public GooglePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SearchField => Driver.FindElement(By.XPath(@"//input[@class='gLFyf gsfi']"));
        public IWebElement GoogleLogo => Driver.FindElement(By.Id("hplogo"));

        public IWebElement SearchButton => Driver.FindElement(By.XPath(@"//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));

        public IWebElement Result => Driver.FindElement(By.XPath(@"//*[@id='rso']/div[1]/div/div/div/div[1]/a"));

        public String DriverTitle => Driver.Title;

        public void Navigate()
        {
            Navigate("https://www.google.com/");
        }

        public void Search(String Input)
        {
            SearchField.Clear();
            SearchField.SendKeys(Input);
            GoogleLogo.Click();
            SearchButton.Click();
        }

        public void ClickOnFirstResult()
        {
            Result.Click();
        }
    }
}
