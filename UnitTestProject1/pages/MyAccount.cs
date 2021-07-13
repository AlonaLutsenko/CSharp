using OpenQA.Selenium;
using System;

namespace UnitTestProject1.pages
{
    public class MyAccount : BaseCommon
    {
        private IWebElement buttonMyWishlist { get { return Driver.FindElement(By.CssSelector("a[title='My wishlists']")); } }
        private IWebElement buttonMyPersonalInformation { get { return Driver.FindElement(By.LinkText("Information")); } }

        public MyAccount(IWebDriver driver) : base(driver) { }
    }
}