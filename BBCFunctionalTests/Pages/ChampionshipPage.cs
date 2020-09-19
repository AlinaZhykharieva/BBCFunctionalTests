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

        public int GetActualNumberOfGoalsScoredByTheFirstTeam(string nameOfTheFirstTeam, string nameOfSecondTeam)
        {
            //span[ starts-with( descendant-or-self::*/text(),'Ayr' ) ]//ancestor::a/article//span[contains(text(),'Alloa')]//ancestor::span[@class= 'sp-c-fixture__team sp-c-fixture__team--home']//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']
            WaitForLoad(DriverInstance.Current);
            return int.Parse(DriverInstance.Current.FindElement(By.XPath("//span[ starts-with( descendant-or-self::*/text(),'" + nameOfSecondTeam + "') ]//ancestor::a/article//span[contains(text(),'" + nameOfTheFirstTeam + "')]//ancestor::span[@class= 'sp-c-fixture__team sp-c-fixture__team--home']")).Text);

        }

        public int GetActualNumberOfGoalsScoredByTheSecondTeam(string nameOfTheFirstTeam, string nameOfSecondTeam )
        {   
            WaitForLoad(DriverInstance.Current);
            return int.Parse(DriverInstance.Current.FindElement(By.XPath("//span[ starts-with( descendant-or-self::*/text(),'" + nameOfTheFirstTeam + "') ]//ancestor::a/article//span[contains(text(),'" + nameOfSecondTeam + "')]//ancestor::span[@class= 'sp-c-fixture__team sp-c-fixture__team--away']//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")).Text);
        }
        public DetailMatchPage ClickLinkOfMatch(string firstTeam, string secondTeam) 
        {
            
            DriverInstance.Current.FindElement(By.XPath("//span[ starts-with( descendant-or-self::*/text(),'" + firstTeam + "' ) ]//ancestor::a/article//span[contains(text(),'" + secondTeam + "')]//ancestor::a")).Click();
            WaitForLoad(DriverInstance.Current);
            return new DetailMatchPage(DriverInstance.Current);
        }
       









    }
}
