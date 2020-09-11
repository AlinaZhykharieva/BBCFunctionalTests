using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class SportPage: BasePage
    {
        public SportPage(IWebDriver driver) : base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//li[@class= 'sp-c-sport-navigation__item ']/a[@data-stat-title='Football']")]
        private IWebElement MenuFootball;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='close']")]
        private IWebElement ButtonCloseOnPopUpWithProposeOfSabscription;

        public void ClickOnMenuFootball() 
        {
            MenuFootball.Click();
            WaitForLoad(driver, 15);
        }
        public void ClickOnButtonCloseOnPopUpWithProposeOfSabscription()
        {
            ButtonCloseOnPopUpWithProposeOfSabscription.Click();
            WaitForLoad(driver, 15);
        }

    }
}
