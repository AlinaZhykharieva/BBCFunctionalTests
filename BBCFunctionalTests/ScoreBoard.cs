
using OpenQA.Selenium;
using System;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class Score
    {
        public int NumberOfGoalsScoredByTheFirstTeam { get; set; }
        public int NumberOfGoalsScoredByTheSecondTeam { get; set; }
        public Score (int numberGoalFirstTeam, int numberGoalSecondTeam)
        {
            NumberOfGoalsScoredByTheFirstTeam = numberGoalFirstTeam;
            NumberOfGoalsScoredByTheSecondTeam = numberGoalSecondTeam;
        }
        public override bool Equals(object obj)
        {
            Score score = obj as Score;
            return NumberOfGoalsScoredByTheFirstTeam.Equals(score.NumberOfGoalsScoredByTheFirstTeam) && NumberOfGoalsScoredByTheSecondTeam.Equals(score.NumberOfGoalsScoredByTheSecondTeam);

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
    public class ScoreBoard:BasePage
    {

        public ScoreBoard(IWebDriver driver) : base(driver)
        {

        }
        
        public Score GetScore(string team1, string team2)
        {
            ChampionshipPage championshipPage = new ChampionshipPage(driver);
                      
            if (team1.Equals(championshipPage.GetActualFirstTeam()) && team2.Equals(championshipPage.GetActualSecondTeam()))
            {
               
                return new Score(championshipPage.GetActualNumberOfGoalsScoredByTheFirstTeam(), championshipPage.GetActualNumberOfGoalsScoredByTheSecondTeam());

            }
            else
            {
                WaitForLoad(driver, 10);
                throw new ArgumentException("Please, Enter valid name of teams", championshipPage.GetActualSecondTeam());
            }



        }

    }

}
