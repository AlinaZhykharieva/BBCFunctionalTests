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
            HomePage homePage = new HomePage(DriverInstance.Current);
            homePage.ClickOnMenuSportInNavBar().ClickOnButtonCloseOnPopUpWithProposeOfSabscription().ClickOnMenuFootball().ClickOnMenuScoresAndFixturesOnFootballPage();

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

        [Then(@"the score from which the teams ""(.*)"" and ""(.*)"" played should be ""(.*)"" ""(.*)""")]
        public void ThenTheScoreFromWhichTheTeamsAndPlayedShouldBe(string expectedFirstTeam, string expectedSecondTeam, Int32 scoreFirstTeam, Int32 scoreSecondTem )
        {
            ScoreBoard scoreBoard = new ScoreBoard(DriverInstance.Current);
            Score score = new Score(scoreFirstTeam, scoreSecondTem);
            Assert.AreEqual(scoreBoard.GetScore(expectedFirstTeam, expectedSecondTeam), score);
           
        }

        [Then(@"go to page where the teams ""(.*)"" and ""(.*)"" details of match")]
        public void ThenGoToPageWhereTheTeamsAndDetailsOfMatch(string actualFirstTeam, string actualSecondTeam)
        {
            ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);
            championshipPage.ClickLinkOfMatch(actualFirstTeam, actualSecondTeam);
        }

        [Then(@"the names of teams should be as expected ""(.*)"" and ""(.*)""")]
        public void ThenTheNamesOfTeamsShouldBeAsExpectedAnd(string expectredFirstTeam, string expectedSecondTeam)
        {
            DetailMatchPage detailMatchPage = new DetailMatchPage(DriverInstance.Current);
            Assert.AreEqual(expectredFirstTeam, detailMatchPage.GetActualFirstTeamOnMatchDetailPage());
            Assert.AreEqual(expectedSecondTeam, detailMatchPage.GetActualSecondTeamOnMatchDetailPage());
        }


        [Then(@"the score should be ""(.*)"" ""(.*)""")]
        public void ThenTheScoreShouldBe(int numberOfGoalsScoredByTheFirstTeam, int numberOfGoalsScoredByTheSecondTeam)
        {
            DetailMatchPage detailMatchPage = new DetailMatchPage(DriverInstance.Current);
            Assert.AreEqual(numberOfGoalsScoredByTheFirstTeam, detailMatchPage.GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
            Assert.AreEqual(numberOfGoalsScoredByTheSecondTeam, detailMatchPage.GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
        }

    }
}
