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
        private readonly IWebElement InputFieldOnScoresAndFixturesPage;

        [FindsBy(How = How.XPath, Using = "//a[@id='downshift-0-item-0']")]
        private readonly IWebElement ButtonSearchOnScoresAndFixturesPage;



        public ScoresAndFixturesPage SendKeyWordForSearchChampionship(string keyWordForSearchChampionship) 
        {
            InputFieldOnScoresAndFixturesPage.SendKeys(keyWordForSearchChampionship);
            Utilities.Waits.WaitForLoad();
            return new ScoresAndFixturesPage(DriverInstance.Current);
        }


        public void ClickOnButtonSearchOnScoresAndFixturesPage()
        {
            ButtonSearchOnScoresAndFixturesPage.Click();
            Utilities.Waits.WaitForLoad();


        }


    }
}
