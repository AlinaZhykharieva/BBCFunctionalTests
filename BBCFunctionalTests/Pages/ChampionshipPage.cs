using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace BBCFunctionalTests
{
    public class ChampionshipPage: BasePage
    {
        public ChampionshipPage(IWebDriver driver): base (driver)
        {

        }
       
        [FindsBy(How = How.XPath, Using = "//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']")]
        private IWebElement ActualNumberOfGoalsScoredByTheFirstTeam;

        [FindsBy(How = How.XPath, Using = "//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")]
        private IWebElement ActualNumberOfGoalsScoredByTheSecondTeam;

        public void ChoosePeriodMonthAndYear(string date) 
        {
            DriverInstance.Current.FindElement(By.XPath("//a[contains(@href, '" + date + "')]")).Click();
            WaitForLoad(DriverInstance.Current);
            
        }

        //public string GetActualFirstTeam() 
        //{
        //    WaitForLoad(DriverInstance.Current);
            
        //    return ActualFirstTeam.Text;
            
        //}

        //public string GetActualSecondTeam() 
        //{
        //    WaitForLoad(DriverInstance.Current);
           
        //    return ActualSecondTeam.Text;
            
        //}

        public int GetActualNumberOfGoalsScoredByTheFirstTeam()
        {
            WaitForLoad(DriverInstance.Current);
            return int.Parse(ActualNumberOfGoalsScoredByTheFirstTeam.Text);
           
        }

        public int GetActualNumberOfGoalsScoredByTheSecondTeam() 
        {
            WaitForLoad(DriverInstance.Current);
            return int.Parse(ActualNumberOfGoalsScoredByTheSecondTeam.Text);
        }
        public DetailMatchPage ClickLinkOfMatch(string linkForNumberOfMatch) 
        {

            DriverInstance.Current.FindElement(By.XPath("//a[contains(@href, '" + linkForNumberOfMatch + "')]")).Click();
            WaitForLoad(DriverInstance.Current);
            return new DetailMatchPage(DriverInstance.Current);
        }
       









    }
}
