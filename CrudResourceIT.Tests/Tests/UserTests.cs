using CrudResourceIT.Tests.PageObject;
using CrudResourceIT.Tests.PageObjects;
using Xunit;

namespace CrudResourceIT.Tests.Tests
{
    public class UserTests : SeleniumBase
    {
        private readonly UserPage userPageObject;
        private readonly CommonPage commonPage;
        public UserTests()
        {
            driver.Navigate().GoToUrl(url);
            userPageObject = new UserPage(driver);
            commonPage = new CommonPage(driver);
        }

        [Fact]
        public void SaveUser()
        {
            userPageObject.Save("walter.vlopes@gmail.com", "Walter", "Cardoso", "928582709", "Av nossa senhora do sabara");
        } 
    }
}
