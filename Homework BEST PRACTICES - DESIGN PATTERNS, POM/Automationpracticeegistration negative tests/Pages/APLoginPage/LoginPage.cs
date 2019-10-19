using Homework03SeleniumAdvanced;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages
{
    public class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver) : base (driver)
        {
        }

        public IWebElement Email => Driver.FindElement(By.Id("email_create"));

        public IWebElement Submit => Driver.FindElement(By.Id("SubmitCreate"));

        public void Navigate()
        {
            Navigate("http://automationpractice.com/index.php?controller=my-account");

        }
       
        public void SignIn()
        {
            //generate random int
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(10000, 20000);

            //Enter email and click on Create an account button 
            Email.SendKeys($"username{randomInt}@gmail.com");
            Submit.Click();
        }

    }
}
