using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System;

namespace Homework.Pages
{
    public class APHomePage:BasePage
    {
        public APHomePage(IWebDriver driver) : base(driver)
        {
        }
            public IWebElement SignInButton => Driver.FindElement(By.PartialLinkText(@"Sign in"));

        public void Navigate()
        {
            Navigate("http://automationpractice.com/index.php");

        }

        public void SignIn()
        {
            SignInButton.Click();
        }
    }
}
