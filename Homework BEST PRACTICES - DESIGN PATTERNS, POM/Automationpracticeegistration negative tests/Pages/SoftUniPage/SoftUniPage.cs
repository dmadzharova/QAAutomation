using Homework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hamework.Pages
{
    public class SoftUniPage : BasePage
    {
        public SoftUniPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TrainingsItem => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/a/span")); 
        public IWebElement TrainingQAAutomation => Driver.FindElement(By.XPath(@"//*[@id=""header-nav""]/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul[2]/div[1]/ul/li/a"));

        public void Navigate()
        {
            Navigate("https://www.softuni.bg/");
        }

        public void FindQACourse()
        {
            TrainingsItem.Click();
            TrainingQAAutomation.Click();
        }

    }
}
