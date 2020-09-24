using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using System;

namespace BBCFunctionalTests
{
    public class ChampionshipPage: BasePage
    {
        public ChampionshipPage(IWebDriver driver): base (driver)
        {

        }
       
        public void ChoosePeriodMonthAndYear(string date) 
        {
            DateTime convertedDate = Convert.ToDateTime(date);
            if (convertedDate < DateTime.Now)
            {
                DriverInstance.Current.FindElement(By.XPath("//a[contains(@href, '" + date + "')]")).Click();
            }
            else 
            {
                throw new ArgumentOutOfRangeException(date);
            }
            
        }

       
        public int GetActualNumberOfGoalsScoredByTheFirstTeam(string nameOfTheFirstTeam, string nameOfSecondTeam)
        {
            
          
            return int.Parse(DriverInstance.Current.FindElement(By.XPath("//span[ starts-with( descendant-or-self::*/text(),'" + nameOfSecondTeam + "') ]//ancestor::a/article//span[contains(text(),'" + nameOfTheFirstTeam + "')]//ancestor::span[@class= 'sp-c-fixture__team sp-c-fixture__team--home']//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']")).Text);

        }

        public int GetActualNumberOfGoalsScoredByTheSecondTeam(string nameOfTheFirstTeam, string nameOfSecondTeam )
        {   
         
            return int.Parse(DriverInstance.Current.FindElement(By.XPath("//span[ starts-with( descendant-or-self::*/text(),'" + nameOfTheFirstTeam + "') ]//ancestor::a/article//span[contains(text(),'" + nameOfSecondTeam + "')]//ancestor::span[@class= 'sp-c-fixture__team sp-c-fixture__team--away']//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")).Text);
        }
        public void ClickLinkOfMatch(string firstTeam, string secondTeam) 
        {
            
            DriverInstance.Current.FindElement(By.XPath("//span[ starts-with( descendant-or-self::*/text(),'" + firstTeam + "' ) ]//ancestor::a/article//span[contains(text(),'" + secondTeam + "')]//ancestor::a")).Click();
           
            
        }
      
    }
}
