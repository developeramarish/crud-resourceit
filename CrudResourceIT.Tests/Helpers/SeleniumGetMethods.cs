using OpenQA.Selenium;

namespace CrudResourceIT.Tests.Helpers
{
    public static class SeleniumGetMethods
    {
        public static string GetInnerText(this IWebElement element)
           => element.GetAttribute("innerText");
    }
}
