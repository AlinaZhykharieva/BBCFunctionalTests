using BBCFunctionalTests.Driver;
using BBCFunctionalTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using Assert = NUnit.Framework.Assert;

namespace BBCFunctionalTests
{
    public class BCFunctionalTests : BaseTest
    {

       
            

     
        [Test]
        public void CheckTheTitleOfMainArticleOnNewsPage()
        {
            
            string expectedTitleOfMainArticleOnNewsPage = "Poisoned Navalny 'will return to Russia'";
            HomePage homePage = new HomePage(DriverInstance.Current);
            Assert.IsTrue(homePage.ClickOnMenuNews().GetActualTitleOfMainArticleOnHomePage().Contains(expectedTitleOfMainArticleOnNewsPage));


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
            HomePage homePage = new HomePage(DriverInstance.Current);
           
            List<string> secondaryTitlesString = new List<string>();
            foreach (IWebElement webElement in homePage.ClickOnMenuNews().GetSecondaryArticleTitle())
            {
                string textsecondaryTitlesString = webElement.Text;
                secondaryTitlesString.Add(textsecondaryTitlesString);
            }
            for (int i = 0; i < secondaryTitlesString.Count; i++)
            {
                Assert.IsTrue(secondaryTitlesString.Contains(secondaryTitles[1]));
            }

        }
        //[Test]

        //public void CheckTheNameOfTheArticleOnSearchedPage()
        //{
        //    string expectedTitleArticle = "BBC OS Conversations: Coronavirus: Children with special needs";
        //    HomePage homePage = new HomePage(DriverInstance.Current);
        //    Assert.IsTrue(homePage.ClickOnMenuNews().SendKeysInSearchInputOnNewsPage().GetTitleArticle().Contains(expectedTitleArticle));

        //}

        private Dictionary<string, string> StoryToBBCWithNameFieldBlank = new Dictionary<string, string>()
        {
            { "Tell us your story. ", "My story" },
            { "Name", "" },
            { "I am over 16 years old", "Yes"  },
            { "I accept the ", "Yes"}


         };

        [Test]
        public void CheckThatUserCanSubmitAQuestionToBBCWithNameFieldBlank()
        {
            HowToShareWithBBCNewsPage howToShareWithBBCNewsPage = new HowToShareWithBBCNewsPage(DriverInstance.Current);

            IList<IWebElement> ListErrorMessages = howToShareWithBBCNewsPage.GetListOfErrorMessages();
            BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
            Form form = new Form(DriverInstance.Current);
            businessLogicLayer.GoToHowToShareWithBBCNews();
            form.FillForm(StoryToBBCWithNameFieldBlank);
            Assert.IsTrue(ListErrorMessages.Any());
        }
        private Dictionary<string, string> StoryToBBCWithTheStoryFieldBlank = new Dictionary<string, string>()
        {
            { "Tell us your story. ", "" },
            { "Name", "Alina" },
            { "I am over 16 years old", "Yes"  },
            { "I accept the ", "Yes"}


         };

        [Test]
        public void CheckThatUserCanSubmitAQuestionToBBCStoryToBBCWithTheStoryFieldBlank()
        {
            HowToShareWithBBCNewsPage howToShareWithBBCNewsPage = new HowToShareWithBBCNewsPage(DriverInstance.Current);

            IList<IWebElement> ListErrorMessages = howToShareWithBBCNewsPage.GetListOfErrorMessages();
            BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
            Form form = new Form(DriverInstance.Current);
            businessLogicLayer.GoToHowToShareWithBBCNews();
            form.FillForm(StoryToBBCWithTheStoryFieldBlank);
            Assert.IsTrue(ListErrorMessages.Any());
        }
        private Dictionary<string, string> StoryToBBCWithTheIAcceptTheTermsOfServiceNotChecked = new Dictionary<string, string>()
        {
            { "Tell us your story. ", "My story" },
            { "Name", "Alina" },
            { "I am over 16 years old", "Yes"  },
            { "I accept the ", "No"}


         };

        [Test]
        public void CheckThatUserCanSubmitAQuestionToBBCWithTheIAcceptTheTermsOfServiceNotChecked()
        {
            HowToShareWithBBCNewsPage howToShareWithBBCNewsPage = new HowToShareWithBBCNewsPage(DriverInstance.Current);

            IList<IWebElement> ListErrorMessages = howToShareWithBBCNewsPage.GetListOfErrorMessages();
            BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
            Form form = new Form(DriverInstance.Current);
            businessLogicLayer.GoToHowToShareWithBBCNews();
            form.FillForm(StoryToBBCWithTheIAcceptTheTermsOfServiceNotChecked);
            Assert.IsTrue(ListErrorMessages.Any());
        }

        //[Test]
        //public void CheckThatTeamScoresDisplayCorrectlyScottishChampionship()
        //{
        //    string dateOfMatch = "2020-02";
        //    string keyWordForSearchScottishChampionship = "Scottish Championship";
        //    string expectredFirstTeam = "Alloa Athletic";
        //    string expectedSecondTeam = "Ayr United";
        //    string linkForNumberOfMatchScottishChampionship = "51595117";
        //    Score score = new Score(0, 2);

        //    ScoreBoard board = new ScoreBoard(DriverInstance.Current);
        //    BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        //    ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);
        //    businessLogicLayer.GoToTheFootballScoresAndFixtures()
        //   .SendKeyWordForSearchChampionship(keyWordForSearchScottishChampionship).ClickOnButtonSearchOnScoresAndFixturesPage()
        //   .ChoosePeriodMonthAndYear(dateOfMatch);
        //    Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);

        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishChampionship).GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishChampionship).GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectredFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishChampionship).GetActualFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectedSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishChampionship).GetActualSecondTeamOnMatchDetailPage());
        //}
        //[Test]
        //public void CheckThatTeamScoresDisplayCorrectlyChampionshipEuropaLeague()
        //{
        //    string dateOfMatch = "2020-08";
        //    string keyWordForSearchEuropaLeague = "Europa League";
        //    string expectredFirstTeam = "The New Saints";
        //    string expectedSecondTeam = "MSK Zilina";
        //    string linkForNumberOfMatchEuropaLeague = "53876175";
        //    Score score = new Score(3, 1);
        //    ScoreBoard board = new ScoreBoard(DriverInstance.Current);
        //    BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        //    ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);

        //    businessLogicLayer.GoToTheFootballScoresAndFixtures()
        //    .SendKeyWordForSearchChampionship(keyWordForSearchEuropaLeague).ClickOnButtonSearchOnScoresAndFixturesPage()
        //    .ChoosePeriodMonthAndYear(dateOfMatch);
        //    Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchEuropaLeague).GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchEuropaLeague).GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectredFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchEuropaLeague).GetActualFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectedSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchEuropaLeague).GetActualSecondTeamOnMatchDetailPage());

        //}
        //[Test]
        //public void CheckThatTeamScoresDisplayCorrectlyScottishLeagueCup()
        //{
        //    string dateOfMatch = "2019-11";
        //    string keyWordForSearchScottishLeagueCup = "Scottish League Cup";
        //    string expectredFirstTeam = "Rangers";
        //    string expectedSecondTeam = "Heart of Midlothian";
        //    string linkForNumberOfMatchScottishLeagueCup = "50228402";
        //    Score score = new Score(3, 0);

        //    ScoreBoard board = new ScoreBoard(DriverInstance.Current);
        //    BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        //    ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);
        //    businessLogicLayer.GoToTheFootballScoresAndFixtures()
        //   .SendKeyWordForSearchChampionship(keyWordForSearchScottishLeagueCup).ClickOnButtonSearchOnScoresAndFixturesPage()
        //   .ChoosePeriodMonthAndYear(dateOfMatch);
        //    Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishLeagueCup).GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishLeagueCup).GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectredFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishLeagueCup).GetActualFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectedSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchScottishLeagueCup).GetActualSecondTeamOnMatchDetailPage());

        //}
        //[Test]
        //public void CheckThatTeamScoresDisplayCorrectlyWomensWorldCup()
        //{
        //    string dateOfMatch = "2019-07-07";
        //    string keyWordForSearchWomensWorldCup = "Womens World Cup";
        //    string expectredFirstTeam = "USA";
        //    string expectedSecondTeam = "Netherlands";
        //    string linkForNumberOfMatchWomensWorldCup = "48897032";
        //    Score score = new Score(2, 0);

        //    ScoreBoard board = new ScoreBoard(DriverInstance.Current);
        //    BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        //    ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);
        //    businessLogicLayer.GoToTheFootballScoresAndFixtures()

        //   .SendKeyWordForSearchChampionship(keyWordForSearchWomensWorldCup).ClickOnButtonSearchOnScoresAndFixturesPage()
        //   .ChoosePeriodMonthAndYear(dateOfMatch);
        //    Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchWomensWorldCup).GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchWomensWorldCup).GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectredFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchWomensWorldCup).GetActualFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectedSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchWomensWorldCup).GetActualSecondTeamOnMatchDetailPage());

        //}
        //[Test]
        //public void CheckThatTeamScoresDisplayCorrectlyClubWorldCup()
        //{
        //    string dateOfMatch = "2019-12";
        //    string keyWordForSearchScottishChampionship = "Club World Cup";
        //    string expectredFirstTeam = "Liverpool";
        //    string expectedSecondTeam = "Flamengo";
        //    string linkForNumberOfMatchClubWorldCup = "50869633";
        //    Score score = new Score(1, 0);
        //    ScoreBoard board = new ScoreBoard(DriverInstance.Current);
        //    BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();
        //    ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);

        //    businessLogicLayer.GoToTheFootballScoresAndFixtures()
        //    .SendKeyWordForSearchChampionship(keyWordForSearchScottishChampionship).ClickOnButtonSearchOnScoresAndFixturesPage()
        //    .ChoosePeriodMonthAndYear(dateOfMatch);
        //    Assert.AreEqual(board.GetScore(expectredFirstTeam, expectedSecondTeam), score);
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchClubWorldCup).GetActualNumberOfGoalsScoredByTheFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(score.NumberOfGoalsScoredByTheFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchClubWorldCup).GetActualNumberOfGoalsScoredByTheSecondTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectredFirstTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchClubWorldCup).GetActualFirstTeamOnMatchDetailPage());
        //    Assert.AreEqual(expectedSecondTeam, championshipPage.ClickLinkOfMatch(linkForNumberOfMatchClubWorldCup).GetActualSecondTeamOnMatchDetailPage());
        //}

    } 
}
