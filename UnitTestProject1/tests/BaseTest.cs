using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using UnitTestProject1.pages;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Close();
            driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl(@"https://www.google.com/webhp?hl=uk&sa=X&ved=0ahUKEwjJpvmjzN_xAhXcgP0HHYSIAMMQPAgI");
        }
        public MainPage loadApplicationWithLoggedInUser()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GetHeader();
            MyAccount myAccount = mainPage.goToSignInPage().enterEmail().enterPassword().pressSignInButton();
            myAccount.GetHeader();
            return myAccount.GoToMainPage();
        }
    }
}