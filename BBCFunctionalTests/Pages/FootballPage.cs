using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCFunctionalTests
{
    public class FootballPage: BasePage
    {
        public FootballPage(IWebDriver driver): base(driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//a[@data-stat-title='Scores & Fixtures']")]
        private readonly IWebElement MenuScoresAndFixturesOnFootballPage;

        public void ClickOnMenuScoresAndFixturesOnFootballPage()
        {
            MenuScoresAndFixturesOnFootballPage.Click();
            
            
        }

    }
}
