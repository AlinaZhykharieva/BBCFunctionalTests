using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class ScoresAndFixturesPage: BasePage
    {
        public ScoresAndFixturesPage(IWebDriver driver): base (driver)
        {

        }
       
        [FindsBy(How = How.XPath, Using = "//input[@id='downshift-0-input']")]
        private IWebElement InputFieldOnScoresAndFixturesPage;

        [FindsBy(How = How.XPath, Using = "//a[@id='downshift-0-item-0']")]
        private IWebElement ButtonSearchOnScoresAndFixturesPage;



        public ScoresAndFixturesPage SendKeyWordForSearchChampionship(string keyWordForSearchChampionship) 
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(keyWordForSearchChampionship);
            WaitForLoad(DriverInstance.Current);
            return new ScoresAndFixturesPage(DriverInstance.Current);
        }


        public ChampionshipPage ClickOnButtonSearchOnScoresAndFixturesPage()
        {
            ButtonSearchOnScoresAndFixturesPage.Click();
            WaitForLoad(DriverInstance.Current, 30);
            return new ChampionshipPage(DriverInstance.Current);
            
        }


    }
}
