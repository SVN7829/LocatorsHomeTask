using LocatorsHomeTask.Pages;
using LocatorsHomeTask.Base;
using NUnit.Framework;

namespace LocatorsHomeTask
{
    [TestFixture]
    public class Tests : TestBase
    {
        [Test]
        public void EmailMustSendToAnotherUser()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.TypeLogin("nalogud1");
            mainPage.TypePassword("123-VOVA");
            mainPage.EnterLoginAndPassword();
            MBoxPage mBoxPage = new MBoxPage(driver);
            mBoxPage.ClickOnCreateLetterHref();
            CreateLetterPage createLetterPage = new CreateLetterPage(driver);
            createLetterPage.TypeEmailToEmailAdressUserField("svn7829@gmail.com");
            createLetterPage.TypeThemeToThemeField("Example Letter");
            createLetterPage.TypeTextToTextField("Hello!");
            createLetterPage.SendBtnClick();
            Assert.That(driver.PageSource.Contains("Письмо успешно отправлено адресатам"));
        }
    }
}
