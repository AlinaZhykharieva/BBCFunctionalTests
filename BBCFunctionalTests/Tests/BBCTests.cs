using BBCFunctionalTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;

namespace BBCFunctionalTests
{
    public class BCFunctionalTests : BaseTest
    {

        [Test]
        public void CheckTheTitleOfMainArticleOnHomePage()
        {
            string expectedTitleOfMainArticleOnNewsPage = "US black man killed in police 'spit hood' restraint";

            GetHomePage().ClickOnMenuNews();
            GetBasePage().WaitForLoad(driver, 15);
            Assert.IsTrue(GetNewsPage().GetActualTitleOfMainArticleOnHomePage().Contains(expectedTitleOfMainArticleOnNewsPage));


        }
        [Test]
        public void CheckSecondaryArticleTitlesOnNewsPage()
        {
            List<string> secondaryTitles = new List<string>
            {
                "Hopes fade in search for Beirut blast survivor",
                "Professor who posed as black 'won't teach classes'",
                "Earth's 'lost species' only the tip of the iceberg",
                "Trump refuses to condemn Russia over Navalny",
                "Drone filmed dropping suspected cannabis over city"
            };

            GetHomePage().ClickOnMenuNews();
            GetBasePage().WaitForLoad(driver, 15);
            List<string> secondaryTitlesString = new List<string>();
            foreach (IWebElement webElement in GetNewsPage().GetSecondaryArticleTitle())
            {
                string textsecondaryTitlesString = webElement.Text;
                secondaryTitlesString.Add(textsecondaryTitlesString);

            }

            for (int i = 0; i < secondaryTitlesString.Count; i++)
            {
                Assert.IsTrue(secondaryTitlesString.Contains(secondaryTitles[1]));

            }

        }
        [Test]

        public void CheckTheNameOfTheArticleOnSearchedPage()
        {
            string expectedTitleArticle = "BBC OS Conversations: Coronavirus: Children with special needs";
            HomePage page = new HomePage(driver);
            
            page.ClickOnMenuNews();
            GetBasePage().WaitForLoad(driver, 15);
            GetNewsPage().GetTagName();
            GetBasePage().WaitForLoad(driver, 15);
            Assert.IsTrue(GetSearchPage().GetTitleArticle().Contains(expectedTitleArticle));

        }
        [Test]
        public void CheckThatUserCanSubmitAQuestionToBBC()
        {
            GetHomePage().ClickOnMenuNews();
            GetNewsPage().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            GetBasePage().WaitForLoad(driver, 10);
            GetNewsPage().ClickOnMenuCoronavirus();
            GetBasePage().WaitForLoad(driver, 10);
            new CoronavirusPage(driver).ClickLinkYourCoronavirusStories();
            GetBasePage().WaitForLoad(driver, 10);
            new YourCoronavirusStoriePage(driver).ClickOnLinkHowToShareWithBBCNews();
        }


        [Test]
        public void CheckThatTeamScoresDisplayCorrectlyScottishChampionship()
        {
            string expectredFirstTeam = "Alloa Athletic";
            string expectedSecondTeam = "Ayr United";
            Score score = new Score(0, 2);
            
            ScoreBoard board = new ScoreBoard(driver);

            new BusinessLogicLayer(driver).GoToTheFootballScoresAndFixtures();
            GetScoresAndFixturesPage().SendKeyWordForSearchScottishChampionship();
            GetScoresAndFixturesPage().ClickOnButtonSearchOnScoresAndFixturesPage();
            GetChampionshipPage().ChoosePeriodMonthAndYearScottishChampionship();
            Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);
            GetChampionshipPage().ClickLinkForNumberOfMatchScottishChampionship();
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
            Assert.AreEqual(expectredFirstTeam, GetDetailMatchPage().GetActualFirstTeamOnMatchDetailPage());
            Assert.AreEqual(expectedSecondTeam, GetDetailMatchPage().GetActualSecondTeamOnMatchDetailPage());
        }
        [Test]
        public void CheckThatTeamScoresDisplayCorrectlyChampionshipEuropaLeague()
        {
            string expectredFirstTeam = "The New Saints";
            string expectedSecondTeam = "MSK Zilina";
            Score score = new Score(3, 1);
            ScoreBoard board = new ScoreBoard(driver);

            new BusinessLogicLayer(driver).GoToTheFootballScoresAndFixtures();
            GetScoresAndFixturesPage().SendKeyWordForSearchEuropaLeague();
            GetScoresAndFixturesPage().ClickOnButtonSearchOnScoresAndFixturesPage();
            GetChampionshipPage().ChoosePeriodMonthAndYearEuropaLeague();
            Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);

            GetChampionshipPage().ClickLinkForNumberOfMatchEuropaLeague();
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
            Assert.AreEqual(expectredFirstTeam, GetDetailMatchPage().GetActualFirstTeamOnMatchDetailPage());
            Assert.AreEqual(expectedSecondTeam, GetDetailMatchPage().GetActualSecondTeamOnMatchDetailPage());

        }
        [Test]
        public void CheckThatTeamScoresDisplayCorrectlyScottishLeagueCup()
        {
            string expectredFirstTeam = "Rangers";
            string expectedSecondTeam = "Heart of Midlothian";
            Score score = new Score(3, 0);
            ScoreBoard board = new ScoreBoard(driver);

            new BusinessLogicLayer(driver).GoToTheFootballScoresAndFixtures();
            GetScoresAndFixturesPage().SendKeyWordForSearchScottishLeagueCup();
            GetScoresAndFixturesPage().ClickOnButtonSearchOnScoresAndFixturesPage();
            GetBasePage().ImplicityWait(10);
            GetChampionshipPage().ChoosePeriodMonthAndYearScottishLeagueCup();
            Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);

            GetChampionshipPage().ClickLinkForNumberOfMatchScottishLeagueCup();
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
            Assert.AreEqual(expectredFirstTeam, GetDetailMatchPage().GetActualFirstTeamOnMatchDetailPage());
            Assert.AreEqual(expectedSecondTeam, GetDetailMatchPage().GetActualSecondTeamOnMatchDetailPage());

        }
        [Test]
        public void CheckThatTeamScoresDisplayCorrectlyWomensWorldCup()
        {
            string expectredFirstTeam = "USA";
            string expectedSecondTeam = "Netherlands";
            Score score = new Score(2, 0);
            ScoreBoard board = new ScoreBoard(driver);

            new BusinessLogicLayer(driver).GoToTheFootballScoresAndFixtures();
            GetScoresAndFixturesPage().SendKeyWordForSearchWomensWorldCup();
            GetScoresAndFixturesPage().ClickOnButtonSearchOnScoresAndFixturesPage();
            GetChampionshipPage().ChoosePeriodMonthAndYearWomensWorldCup();
            Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);

            GetChampionshipPage().ClickLinkForNumberOfMatchWomensWorldCup();
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
            Assert.AreEqual(score.NumberOfGoalsScoredByTheSecondTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
            Assert.AreEqual(expectredFirstTeam, GetDetailMatchPage().GetActualFirstTeamOnMatchDetailPage());
            Assert.AreEqual(expectedSecondTeam, GetDetailMatchPage().GetActualSecondTeamOnMatchDetailPage());

        }
        [Test]
        public void CheckThatTeamScoresDisplayCorrectlyClubWorldCup()
        {
            string expectredFirstTeam = "Liverpool";
            string expectedSecondTeam = "Flamengo";
            Score score = new Score(1, 0);
            ScoreBoard board = new ScoreBoard(driver);

            new BusinessLogicLayer(driver).GoToTheFootballScoresAndFixtures();
            GetScoresAndFixturesPage().SendKeyWordForSearchClubWorldCup();
            GetScoresAndFixturesPage().ClickOnButtonSearchOnScoresAndFixturesPage();
            GetScoresAndFixturesPage().SendKeyWordForSearchClubWorldCup();
            GetScoresAndFixturesPage().ClickOnButtonSearchOnScoresAndFixturesPage();
            GetChampionshipPage().ChoosePeriodMonthAndYearClubWorldCup();
            Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);

            GetChampionshipPage().ClickLinkForNumberOfMatchClubWorldCup();
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
            Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, GetDetailMatchPage().GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
            Assert.AreEqual(expectredFirstTeam, GetDetailMatchPage().GetActualFirstTeamOnMatchDetailPage());
            Assert.AreEqual(expectedSecondTeam, GetDetailMatchPage().GetActualSecondTeamOnMatchDetailPage());
        }

    } 
}
