using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBCFunctionalTests
{
    class BusinessLogicLayer
    {
        private readonly IWebDriver driver;
        public BusinessLogicLayer(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void GoToTheFootballScoresAndFixtures()
        {
            new HomePage(driver).ClickOnMenuSportInNavBar();
            new SportPage(driver).ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            new SportPage(driver).ClickOnMenuFootball();
            new FootballPage(driver).ClickOnMenuScoresAndFixturesOnFootballPage();

        }
    }
}
