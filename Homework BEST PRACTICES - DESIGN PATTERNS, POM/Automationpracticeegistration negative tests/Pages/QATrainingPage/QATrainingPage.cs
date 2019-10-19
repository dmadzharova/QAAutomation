using OpenQA.Selenium;

namespace Homework.Pages
{
    public class QATrainingPage : BasePage
    {
        public QATrainingPage(IWebDriver driver) : base(driver)
        {
        }
        public IWebElement HeadingTag => Driver.FindElement(By.XPath(@"/html/body/div[2]/header/h1"));
    }
}
