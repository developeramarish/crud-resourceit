using OpenQA.Selenium;
using CrudResourceIT.Tests.Helpers;

namespace CrudResourceIT.Tests.PageObject
{
    public class UserPage
    {
        private IWebDriver _driver;
        public UserPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement TxtEmail {
            get
            {
                return _driver.FindElement(By.Id("email"));
            }
        }

        private IWebElement TxtFirstName
        {
            get
            {
                return _driver.FindElement(By.Id("firstname"));
            }
        }

        private IWebElement TxtLastName
        {
            get
            {
                return _driver.FindElement(By.Id("lastname"));
            }
        }

        private IWebElement TxtPhone
        {
            get
            {
                return _driver.FindElement(By.Id("phone"));
            }
        }

        private IWebElement TxtAddress
        {
            get
            {
                return _driver.FindElement(By.Id("address"));
            }
        }

        private IWebElement BtnSave
        {
            get
            {
                return _driver.FindElement(By.Id("btnSave"));
            }
        }

        private IWebElement BtnCreate
        {
            get
            {
                return _driver.FindElement(By.Id("btnCreate"));
            }
        }

        public void Save(string email, string name, string lastname, string phone, string address)
        {
            BtnCreate.Click();
            TxtEmail.EnterText(email);
            TxtFirstName.EnterText(name);
            TxtLastName.EnterText(lastname);
            TxtPhone.EnterText(phone);
            TxtAddress.EnterText(address);
            BtnSave.Click();   
        }
    }
}
