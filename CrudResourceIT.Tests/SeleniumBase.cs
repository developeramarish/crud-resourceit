using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace CrudResourceIT.Tests
{
    public abstract class SeleniumBase : IDisposable
    {
        public IWebDriver driver;
        protected string url = "http://localhost:8707";

        public SeleniumBase()
        {
            try
            {
                // coloque o arquivo chromedriver.exe no c temp
                driver = new ChromeDriver(@"C:\Temp\");
                driver.Manage().Window.Maximize();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao rodar o chrome..." + ex.Message);
               
            }
        }

        public void Dispose()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao finalizar o chrome..." + ex.Message);
            }
        }
    }
}
