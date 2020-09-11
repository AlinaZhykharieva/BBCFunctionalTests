using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class ScoresAndFixturesPage: BasePage
    {
        public ScoresAndFixturesPage(IWebDriver driver): base (driver)
        {

        }
        public const string KeyWordForSearchScottishChampionship = "Scottish Championship";
        public const string KeyWordForSearchEuropaLeague = "Europa League";
        public const string KeyWordForSearchScottishLeagueCup = "Scottish League Cup";
        public const string KeyWordForSearchWomensWorldCup = "Womens World Cup";
        public const string KeyWordForSearchClubWorldCup = "Club World Cup";

        [FindsBy(How = How.XPath, Using = "//input[@id='downshift-0-input']")]
        private IWebElement InputFieldOnScoresAndFixturesPage;

        [FindsBy(How = How.XPath, Using = "//a[@id='downshift-0-item-0']")]
        private IWebElement ButtonSearchOnScoresAndFixturesPage;



        public void SendKeyWordForSearchScottishChampionship() 
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(KeyWordForSearchScottishChampionship);
            WaitForLoad(driver, 15);


        }
        public void SendKeyWordForSearchEuropaLeague() 
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(KeyWordForSearchEuropaLeague);
            WaitForLoad(driver, 15);
        }

        public void SendKeyWordForSearchScottishLeagueCup()
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(KeyWordForSearchScottishLeagueCup);
            WaitForLoad(driver, 15);
        }

        public void SendKeyWordForSearchWomensWorldCup() 
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(KeyWordForSearchWomensWorldCup);
            WaitForLoad(driver, 15);
        }

        public void SendKeyWordForSearchClubWorldCup() 
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(KeyWordForSearchClubWorldCup);
            WaitForLoad(driver, 15);
        }


        public void ClickOnButtonSearchOnScoresAndFixturesPage()
        {
            ButtonSearchOnScoresAndFixturesPage.Click();
        }


    }
}
