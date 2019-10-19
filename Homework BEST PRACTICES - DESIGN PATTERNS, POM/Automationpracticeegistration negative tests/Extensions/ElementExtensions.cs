using OpenQA.Selenium;

namespace Homework.Extensions
{
    public static class ElementExtension
    {
        public static void Type(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

    }
}