using OpenQA.Selenium;

namespace UnitTestProject1.pages
{
    public abstract class BaseCommon : BasePage
    {
        private HeaderComponent headerComponent;
        private FooterComponent footerComponent;
        protected BaseCommon(IWebDriver driver) : base(driver) { }

        public void GetHeader() => headerComponent = new HeaderComponent(Driver);
        public void GetFooter() => footerComponent = new FooterComponent(Driver);
        public SignIn goToSignInPage()
        {
            return headerComponent.ClickOnSighInBtn();
        }
        public MainPage GoToMainPage()
        {
            return headerComponent.GoToMainPage();
        }
    }
}