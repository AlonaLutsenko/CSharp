using OpenQA.Selenium;
using System;

namespace UnitTestProject1.pages
{
    public abstract class FooterComponent : BasePage
    {
        public FooterComponent(IWebDriver driver) : base(driver) { }
    }
}