using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LocatorsHomeTask.Base
{
    public class TestBase
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://mail.i.ua/");
        }

        [TearDown]
        public void CleanUp() 
        {
            driver.Close();
        }
    }
}
