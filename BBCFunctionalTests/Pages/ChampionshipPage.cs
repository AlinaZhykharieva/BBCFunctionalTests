using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace BBCFunctionalTests
{
    public class ChampionshipPage: BasePage
    {
        public ChampionshipPage(IWebDriver driver): base (driver)
        {

        }
       
        public const string periodMonthAndYearScottishChampionship = "2020-02";
        public const string periodMonthAndYearEuropaLeague = "2020-08";
        public const string periodMonthAndYearScottishLeagueCup = "2019-11";
        public const string periodMonthAndYearWomensWorldCup = "2019-07-07";
        public const string periodMonthAndYearClubWorldCup = "2019-12";

        public const string linkForNumberOfMatchScottishChampionship = "51595117";
        public const string linkForNumberOfMatchScottishLeagueCup = "50228402";
        public const string linkForNumberOfMatchEuropaLeague = "53876175";
        public const string linkForNumberOfMatchWomensWorldCup = "48897032";
        public const string linkForNumberOfMatchClubWorldCup = "50869633";

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + periodMonthAndYearScottishChampionship + "')]")]
        private IWebElement PeriodMonthAndYearScottishChampionship;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + periodMonthAndYearEuropaLeague + "')]")]
        private IWebElement PeriodMonthAndYearEuropaLeague;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + periodMonthAndYearScottishLeagueCup + "')]")]
        private IWebElement PeriodMonthAndYearEuropaLeagueScottishLeagueCup;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + periodMonthAndYearWomensWorldCup + "')]")]
        private IWebElement PeriodMonthAndYearWomensWorldCup;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + periodMonthAndYearClubWorldCup + "')]")]
        private IWebElement PeriodMonthAndYearClubWorldCup;


        [FindsBy(How = How.XPath, Using = "//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__team-name sp-c-fixture__team-name--home']")]
        private IWebElement ActualFirstTeam;

        [FindsBy(How = How.XPath, Using = "//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__team-name sp-c-fixture__team-name--away']")]
        private IWebElement ActualSecondTeam;

        [FindsBy(How = How.XPath, Using = "//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']")]
        private IWebElement ActualNumberOfGoalsScoredByTheFirstTeam;

        [FindsBy(How = How.XPath, Using = "//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")]
        private IWebElement ActualNumberOfGoalsScoredByTheSecondTeam;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + linkForNumberOfMatchScottishChampionship + "')]")]
        private IWebElement LinkForNumberOfMatchScottishChampionship;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + linkForNumberOfMatchScottishLeagueCup + "')]")]
        private IWebElement LinkForNumberOfMatchScottishLeagueCup;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + linkForNumberOfMatchEuropaLeague + "')]")]
        private IWebElement LinkForNumberOfMatchEuropaLeague;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + linkForNumberOfMatchWomensWorldCup + "')]")]
        private IWebElement LinkForNumberOfMatchWomensWorldCup;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, '" + linkForNumberOfMatchClubWorldCup + "')]")]
        private IWebElement LinkForNumberOfMatchClubWorldCup;

        public void ChoosePeriodMonthAndYearScottishChampionship() 
        {
            PeriodMonthAndYearScottishChampionship.Click();
            WaitForLoad(driver, 20);
        }

        public void ChoosePeriodMonthAndYearEuropaLeague()
        {
            PeriodMonthAndYearEuropaLeague.Click();
            WaitForLoad(driver, 15);
        }

        public void ChoosePeriodMonthAndYearScottishLeagueCup()
        {
            PeriodMonthAndYearEuropaLeagueScottishLeagueCup.Click();
            WaitForLoad(driver, 15);
        }

        public void ChoosePeriodMonthAndYearWomensWorldCup() 
        {
            PeriodMonthAndYearWomensWorldCup.Click();
            WaitForLoad(driver, 15);
        }

        public void ChoosePeriodMonthAndYearClubWorldCup() 
        {
            PeriodMonthAndYearClubWorldCup.Click();
            WaitForLoad(driver, 15);
        }


        public string GetActualFirstTeam() 
        {
            WaitForLoad(driver, 15);
            
            return ActualFirstTeam.Text;
            
        }

        public string GetActualSecondTeam() 
        {
            WaitForLoad(driver, 15);
           
            return ActualSecondTeam.Text;
            
        }

        public int GetActualNumberOfGoalsScoredByTheFirstTeam()
        {
            WaitForLoad(driver, 15);
            return int.Parse(ActualNumberOfGoalsScoredByTheFirstTeam.Text);
           
        }

        public int GetActualNumberOfGoalsScoredByTheSecondTeam() 
        {
            WaitForLoad(driver, 15);
            return int.Parse(ActualNumberOfGoalsScoredByTheSecondTeam.Text);
        }
        public void ClickLinkForNumberOfMatchScottishChampionship() 
        {
            
            LinkForNumberOfMatchScottishChampionship.Click();
            WaitForLoad(driver, 15);
        }
        public void ClickLinkForNumberOfMatchScottishLeagueCup()
        {
            
            LinkForNumberOfMatchScottishLeagueCup.Click();
            WaitForLoad(driver, 15);
        }
        public void ClickLinkForNumberOfMatchEuropaLeague() 
        {
            LinkForNumberOfMatchEuropaLeague.Click();
            WaitForLoad(driver, 15);
        }

        public void ClickLinkForNumberOfMatchWomensWorldCup() 
        {
            LinkForNumberOfMatchWomensWorldCup.Click();
            WaitForLoad(driver, 15);
        }

        public void ClickLinkForNumberOfMatchClubWorldCup() 
        {
            LinkForNumberOfMatchClubWorldCup.Click();
            WaitForLoad(driver, 15);
        }









    }
}
