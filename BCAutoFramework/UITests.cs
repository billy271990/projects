using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BCAutoFramework
{
    public class UITests
    {
        public IWebDriver Driver;
        public WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");

            Driver = new ChromeDriver();
        }

        [Test]
        public void navigateToWebsite()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}