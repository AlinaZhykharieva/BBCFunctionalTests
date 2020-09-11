using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BBCFunctionalTests
{
    public class BaseTest
    {
        public IWebDriver driver;
        private readonly string BBC_URL = "https://www.bbc.com";

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(BBC_URL);
            driver.Manage().Window.Maximize();

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
        public IWebDriver GetDriver()
        {
            return driver;
        }

        public BasePage GetBasePage()
        {
            return new BasePage(GetDriver());
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }
        public NewsPage GetNewsPage()
        {
            return new NewsPage(GetDriver());
        }
        public SearchPage GetSearchPage()
        {
            return new SearchPage(GetDriver());
        }
        public SportPage GetSportPage() 
        {
            return new SportPage(GetDriver());
        }
        public FootballPage GetFootballPage()
        {
            return new FootballPage(GetDriver());
        }
        
        public ScoresAndFixturesPage GetScoresAndFixturesPage()
        {
            return new ScoresAndFixturesPage(GetDriver());
        }
        public ChampionshipPage GetChampionshipPage() 
        {
            return new ChampionshipPage(GetDriver());
        }
        public DetailMatchPage GetDetailMatchPage() 
        {
            return new DetailMatchPage(GetDriver());
        }
    }
    
}
