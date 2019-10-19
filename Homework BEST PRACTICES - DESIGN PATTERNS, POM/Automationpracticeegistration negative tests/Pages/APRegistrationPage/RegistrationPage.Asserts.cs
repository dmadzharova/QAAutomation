using NUnit.Framework;

namespace Homework.Pages
{
    public partial class RegistrationPage
    {
        public void AssertErrorMessage(string expectedErrorMessage)
        {
            Assert.AreEqual(expectedErrorMessage, ErrorMessage.Text);
        }
    }
}
