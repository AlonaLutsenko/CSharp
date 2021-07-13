using OpenQA.Selenium;
using System;

namespace UnitTestProject1.pages
{
    public abstract class SignIn : BaseCommon
    {
        private IWebElement InputEmailAddress { get { return Driver.FindElement(By.Id("identifier")); } }
        private IWebElement InputPassword { get { return Driver.FindElement(By.CssSelector(".whsOnd.zHQkBf")); } }
        private IWebElement ButtonSignIn { get { return Driver.FindElement(By.CssSelector(".gb_3.gb_4.gb_9d.gb_3c")); } }
        private const string login = "";
        private const string password = "";
        public SignIn(IWebDriver driver) : base(driver) { }

        public SignIn enterEmail()
        {
            InputEmailAddress.SendKeys(login);
            return this;
        }
        public SignIn enterPassword()
        {
            InputPassword.SendKeys(password);
            return this;
        }
        public MyAccount pressSignInButton()
        {
            ButtonSignIn.Click();
            return new MyAccount(Driver);
        }
    }
}