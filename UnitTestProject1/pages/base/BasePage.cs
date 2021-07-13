using OpenQA.Selenium;

namespace UnitTestProject1.pages
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver) => this.Driver = driver;
        public IWebDriver Driver { get; private set; }
    }
}