using OpenQA.Selenium;
using System;

namespace UnitTestProject1.pages
{
    public abstract class BasePopup : BasePage
    {
        public BasePopup(IWebDriver driver) : base(driver) { }
    }
}
