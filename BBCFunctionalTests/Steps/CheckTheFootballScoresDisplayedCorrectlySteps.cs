using BBCFunctionalTests.Driver;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BBCFunctionalTests.Steps
{
    [Binding]
    public class CheckTheFootballScoresDisplayedCorrectlySteps
    {
        [When(@"I go to the page where football scores and fixtures displays")]
        public void WhenIGoToThePageWhereFootballScoresAndFixturesDisplays()
        {
            BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
            businessLogicLayer.GoToHowToShareWithBBCNews();

        }

        [When(@"choose competition ""(.*)""")]
        public void WhenChooseCompetition(string keyWordForSearch)
        {
            ScoresAndFixturesPage scoresAndFixturesPage = new ScoresAndFixturesPage(DriverInstance.Current);
            scoresAndFixturesPage.SendKeyWordForSearchChampionship(keyWordForSearch).ClickOnButtonSearchOnScoresAndFixturesPage();

        }

        [When(@"choose the period in which the match took place ""(.*)""")]
        public void WhenChooseThePeriodInWhichTheMatchTookPlace(string dateOfMatch)
        {
            ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);
            championshipPage.ChoosePeriodMonthAndYear(dateOfMatch);

        }

        [Then(@"the score from which the teams ""(.*)"" and ""(.*)"" played should be ""(.*)""")]
        public void ThenTheScoreFromWhichTheTeamsAndPlayedShouldBe(string expectredFirstTeam, string expectedSecondTeam, Int32 scoreFirstTeam, Int32 scoreSecondTem )
        {
            ScoreBoard scoreBoard = new ScoreBoard(DriverInstance.Current);
            Score score = new Score(scoreFirstTeam, scoreSecondTem);
            Assert.AreEqual(scoreBoard.GetScore(expectredFirstTeam, expectedSecondTeam), score);
           
        }

        [Then(@"go to page where details of this match")]
        public void ThenGoToPageWhereDetailsOfThisMatch()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the names of teams should be as expected")]
        public void ThenTheNamesOfTeamsShouldBeAsExpected()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the score should be ""(.*)"",""(.*)""")]
        public void ThenTheScoreShouldBe(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
