
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Assert = NUnit.Framework.Assert;

namespace BBCFunctionalTests
{
    class BCFunctionalTests: BaseTest
    {
        

        
        
        [Test]
        public void CheckTheTitleOfMainArticleOnHomePage()
        {
            string expectedTitleOfMainArticleOnNewsPage = "US black man killed in police 'spit hood' restraint";
            
            GetHomePage().ClickOnMenuNews();
            GetBasePage().WaitForLoad(driver, 15);
            //GetNewsPage().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            Assert.IsTrue(GetNewsPage().GetActualTitleOfMainArticleOnHomePage().Contains(expectedTitleOfMainArticleOnNewsPage));
            

        }
        [Test]
        public void CheckSecondaryArticleTitlesOnNewsPage()
        {
            GetHomePage().ClickOnMenuNews();
            //GetNewsPage().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            GetBasePage().WaitForLoad(driver, 15);
            Assert.IsTrue(GetNewsPage().IsSecondaryArticleTitlesOnNewsPage());
          
        }
        [Test]

        public void CheckTheNameOfTheArticleOnSearchedPage()
        {
            string expectedTitleArticle = "BBC OS Conversations: Coronavirus: Children with special needs";

            GetHomePage().ClickOnMenuNews();
            //GetNewsPage().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            GetBasePage().WaitForLoad(driver, 15);
            GetNewsPage().GetTagName();
            GetBasePage().WaitForLoad(driver, 15);
            Assert.IsTrue(GetSearchPage().GetTitleArticle().Contains(expectedTitleArticle));

        }
        [Test]
        public void CheckThatTeamScoresDisplayCorrectly()
        {

            string SearchForAChampionship = "Scottish Championship";
            string periodMonthAndYear = "2020-02";
            string expectredFirstTeam = "Alloa Athletic";
            string expectedSecondTeam = "Ayr United";
            int numberOfGoalsScoredByTheFirstTeam = 0;
            int numberOfGoalsScoredByTheSecondTeam = 2;
            string linkForNumberOfMatch = "51595117";

            GetHomePage().ClickOnMenuSportInNavBar();
            GetBasePage().WaitForLoad(driver, 15);
            //GetNewsPage().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();




            .Click();
            WaitForLoad(driver, 15);
            driver.FindElement(By.XPath("//li[@class= 'sp-c-sport-navigation__item ']/a[@data-stat-title='Scores & Fixtures']")).Click();
            WaitForLoad(driver, 15);
            driver.FindElement(By.XPath("//input[@id='downshift-0-input']")).SendKeys(SearchForAChampionship);
            WaitForLoad(driver, 15);
            driver.FindElement(By.XPath("//a[@id='downshift-0-item-0']")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, '" + periodMonthAndYear + "')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            string actualFirstTeam = driver.FindElement(By.XPath("//div[@class='sp-c-fixture__wrapper']//span[@class='gs-u-display-none gs-u-display-block@m qa-full-team-name sp-c-fixture__team-name-trunc']")).Text;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            string actualSecondTeam = driver.FindElement(By.XPath("//div[@class='sp-c-fixture__wrapper']//span[@class='gs-u-display-none gs-u-display-block@m qa-full-team-name sp-c-fixture__team-name-trunc']")).Text;
            int actualNumberOfGoalsScoredByTheFirstTeam = Int32.Parse(driver.FindElement(By.XPath("//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']")).Text);
            int actualNumberOfGoalsScoredByTheSecondTeam = Int32.Parse(driver.FindElement(By.XPath("//div[@class='sp-c-fixture__wrapper']//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")).Text);
            if ((actualFirstTeam == expectredFirstTeam) && (actualSecondTeam == expectedSecondTeam))
            {
                Assert.AreEqual(numberOfGoalsScoredByTheFirstTeam, actualNumberOfGoalsScoredByTheFirstTeam);
                Assert.AreEqual(numberOfGoalsScoredByTheSecondTeam, actualNumberOfGoalsScoredByTheSecondTeam);
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.XPath("//a[contains(@href, '" + linkForNumberOfMatch + "')]")).Click();
            WaitForLoad(driver, 40);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            int actualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage = Int32.Parse(driver.FindElement(By.XPath("//span[@class='sp-c-fixture__number sp-c-fixture__number--home sp-c-fixture__number--ft']")).Text);
            WaitForLoad(driver, 15);
            int actualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage = Int32.Parse(driver.FindElement(By.XPath("//span[@class='sp-c-fixture__number sp-c-fixture__number--away sp-c-fixture__number--ft']")).Text);
            WaitForLoad(driver, 15);
            Assert.AreEqual(numberOfGoalsScoredByTheFirstTeam, actualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage);
            WaitForLoad(driver, 15);
            Assert.AreEqual(numberOfGoalsScoredByTheSecondTeam, actualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage);
            WaitForLoad(driver, 15);
            string actualFirstTeamOnMatchDetailPage = driver.FindElement(By.XPath("//span[@class= 'sp-c-fixture__team-name sp-c-fixture__team-name--home']/span")).Text;
            WaitForLoad(driver, 15);
            string actualSecondTeamOnMatchDetailPage = driver.FindElement(By.XPath("//span[@class= 'sp-c-fixture__team-name sp-c-fixture__team-name--away']/span")).Text;


            Assert.AreEqual(expectredFirstTeam, actualFirstTeamOnMatchDetailPage);
            Assert.AreEqual(expectedSecondTeam, actualSecondTeamOnMatchDetailPage);
        }


    }


}
