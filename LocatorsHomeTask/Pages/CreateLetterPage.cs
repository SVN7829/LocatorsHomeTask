using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LocatorsHomeTask.Pages
{
    class CreateLetterPage
    {
        public IWebDriver Driver;

        [FindsBy(How = How.CssSelector, Using = "#to")]
        private IWebElement emailAdressUserField { get; set; }

        [FindsBy(How = How.XPath, Using = "//span//input[@type='text']")]
        private IWebElement themeField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#text")]
        private IWebElement textField { get; set; }

        [FindsBy(How = How.XPath, Using = "//p[@class='send_container']//input[@value='Отправить']")]
        private IWebElement sendBtn { get; set; }

        public CreateLetterPage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public CreateLetterPage TypeEmailToEmailAdressUserField(string txt)
        {
            emailAdressUserField.Clear();
            emailAdressUserField.SendKeys(txt);
            return new CreateLetterPage(Driver);
        }

        public CreateLetterPage TypeThemeToThemeField(string txt)
        {
            themeField.Clear();
            themeField.SendKeys(txt);
            return new CreateLetterPage(Driver);
        }

        public CreateLetterPage TypeTextToTextField(string txt)
        {
            textField.Clear();
            textField.SendKeys(txt);
            return new CreateLetterPage(Driver);
        }

        public CreateLetterPage SendBtnClick()
        {
            sendBtn.Click();
            return new CreateLetterPage(Driver);
        }
    }
}
