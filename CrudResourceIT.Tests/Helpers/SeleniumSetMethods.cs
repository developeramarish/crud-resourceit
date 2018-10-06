using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CrudResourceIT.Tests.Helpers
{
    public static class SeleniumSetMethods
    {
        public static void EnterText(this IWebElement element, string value) 
            => element.SendKeys(value);

        public static void Click(this IWebElement element) 
            => element.Click();
    }
}
