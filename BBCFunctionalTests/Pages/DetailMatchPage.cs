using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class DetailMatchPage: BasePage
    {
        public DetailMatchPage(IWebDriver driver):base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']")]
        private readonly IWebElement ActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage;

        [FindsBy(How = How.XPath, Using = "//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")]
        private readonly IWebElement ActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage;

        [FindsBy(How = How.XPath, Using = "//span[@class= 'sp-c-fixture__team-name sp-c-fixture__team-name--home']/span")]
        private readonly IWebElement ActualFirstTeamOnMatchDetailPage;

        [FindsBy(How = How.XPath, Using = "//span[@class= 'sp-c-fixture__team-name sp-c-fixture__team-name--away']/span")]
        private readonly IWebElement ActualSecondTeamOnMatchDetailPage;
        public int GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage() 
        {
            return int.Parse(ActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage.Text);
        }
        public int GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage() 
        {
            return int.Parse(ActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage.Text);
        }

        public string GetActualFirstTeamOnMatchDetailPage() 
        {
            return ActualFirstTeamOnMatchDetailPage.Text;
        }
        public string GetActualSecondTeamOnMatchDetailPage() 
        {
            return ActualSecondTeamOnMatchDetailPage.Text;
        }


    }
}
