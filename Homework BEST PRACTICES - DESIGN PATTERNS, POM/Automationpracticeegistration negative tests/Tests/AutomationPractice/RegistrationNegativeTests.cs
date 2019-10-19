using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Homework.Pages;

namespace Homework.Tests
{

    public class RegistrationNegativeTests : BaseTest
    {

        private IWebDriver _driver;
        private WebDriverWait _wait;
        private RegistrationUser _user;

        private LoginPage _loginPage;
        private RegistrationPage _regPage;


        [SetUp]
        public void TestInit()
        {
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);

            _user = UserFactory.CreateValidUser();
        }

        [Test]
        public void VerifyErrorMsgWhenFirstNameIsMissing()
        {
            _user.FirstName = "";

            _loginPage.Navigate();
            _loginPage.SignIn();
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("firstname is required.");
        }

        [Test]
        public void VerifyErrorMsgWhenPasswordIsMissing()
        {
            _user.Password = "123";

            _loginPage.Navigate();
            _loginPage.SignIn();
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is invalid.");

        }

        [Test]
        public void VerifyErrorMsgWhenBirthdayIsInvalid()
        {
            _user.Month = "";
            _user.Year = "";

            _loginPage.Navigate();
            _loginPage.SignIn();
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("Invalid date of birth");

        }

        [Test]
        public void VerifyErrorMsgWhenNamesAreMissing()
        {
            _user.FirstName = "";
            _user.LastName = "";
            _user.RealFirstName = "";
            _user.RealLastName = "";

            _loginPage.Navigate();
            _loginPage.SignIn();
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("lastname is required.\r\nfirstname is required.");

        }

        [Test]
        public void VerifyErrorMsgWhenAllFieldsAreEmpty()
        {
            _user.FirstName = "";
            _user.LastName = "";
            _user.Gender = "";
            _user.Password = "";
            _user.Date = "";
            _user.Month = "";
            _user.Year = "";
            _user.RealFirstName = "";
            _user.RealLastName = "";
            _user.Company = "";
            _user.Address = "";
            _user.City = "";
            _user.State = "";
            _user.Zip = "";
            _user.Phone = "";
            _user.Alias = "";

            _loginPage.Navigate();
            _loginPage.SignIn();
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("You must register at least one phone number.\r\nlastname is required.\r\nfirstname is required.\r\npasswd is required.\r\naddress1 is required.\r\ncity is required.\r\nThe Zip/Postal code you've entered is invalid. It must follow this format: 00000\r\nThis country requires you to choose a State.");
        }


    }
}

