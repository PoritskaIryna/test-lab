using NUnit.Framework;
using OpenQA.Selenium;
using PagesLab2_Base;
using SeleniumExtras.PageObjects;

namespace PagesLab2_Pages
{
    public class LoginPage : PageBase
    {
        private const string LOGIN = "locked_out_user";
        private const string PASSWORD = "secret_sauce";

        [FindsBy(How = How.Id, Using = "user-name")]
        private IWebElement userNameElement { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement { get; set; }

        [FindsBy(How = How.Id, Using = "login-button")]
        public IWebElement loginBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"login_button_container\"]/div/form/div[3]/h3")]
        public IWebElement ErrorLbl { get; set; }

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void LoginWithNameAndPassword()
        {
            userNameElement.SendKeys(LOGIN);
            Thread.Sleep(1000);
            passwordElement.SendKeys(PASSWORD);
            Thread.Sleep(1000);
            loginBtn.Click();
            Thread.Sleep(1000);
        }

        public void CheckThatUserIsLockedOut()
        {
            String text = ErrorLbl.Text;
            Assert.AreEqual(ErrorLbl.Text, "Epic sadface: Sorry, this user has been locked out.");
        }
    }
}
