using BBCFunctionalTests.Driver;
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

        public FootballPage ClickOnMenuFootball() 
        {
            MenuFootball.Click();
            WaitForLoad(DriverInstance.Current);
            return new FootballPage(DriverInstance.Current);
        }
        public SportPage ClickOnButtonCloseOnPopUpWithProposeOfSabscription()
        {
            ButtonCloseOnPopUpWithProposeOfSabscription.Click();
            WaitForLoad(DriverInstance.Current);
            return new SportPage(DriverInstance.Current);
            
        }

    }
}
