using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LocatorsHomeTask.Pages
{
    public class MainPage
    {
        public IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//input[@name='login']")]
        private IWebElement loginField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='pass']")]
        private IWebElement passwordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement submitBtn { get; set; }

        public MainPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void TypeLogin(string txt)
        {
            loginField.Clear();
            loginField.SendKeys(txt);
        }

        public void TypePassword(string txt) 
        {
            passwordField.Clear();
            passwordField.SendKeys(txt);
        }

        public void EnterLoginAndPassword() 
        {
            submitBtn.Click();
        }
    }
}
