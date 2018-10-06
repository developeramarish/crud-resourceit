using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using CrudResourceIT.Tests.Helpers;
using System;
using Xunit;

namespace CrudResourceIT.Tests.PageObjects
{
    public class CommonPage
    {
        private IWebDriver _driver;

        public CommonPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement WelcomeUserID
        {
            get
            {
                 return _driver.FindElement(By.Id("welcomeUser"), 5);
            }
        }

        public void CheckText(string text)
        {
            var innerText = WelcomeUserID.GetInnerText();
            Assert.Equal(text, innerText);
        }
    }
}
