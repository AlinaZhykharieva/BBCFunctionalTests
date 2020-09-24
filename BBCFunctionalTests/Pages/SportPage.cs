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
        private readonly IWebElement MenuFootball;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='close']")]
        private readonly IWebElement ButtonCloseOnPopUpWithProposeOfSabscription;

        public FootballPage ClickOnMenuFootball() 
        {
            MenuFootball.Click();
            
            return new FootballPage(DriverInstance.Current);
        }
        public SportPage ClickOnButtonCloseOnPopUpWithProposeOfSabscription()
        {
            ButtonCloseOnPopUpWithProposeOfSabscription.Click();
           
            return new SportPage(DriverInstance.Current);
            
        }

    }
}
