using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LocatorsHomeTask.Pages
{
    public class MBoxPage
    {
        IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//p[@class='make_message']//a")]
        private IWebElement CreateLetterHref { get; set; }

        public MBoxPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public MBoxPage ClickOnCreateLetterHref()
        {
            CreateLetterHref.Click();

            return new MBoxPage(Driver);
        }
    } 
}
