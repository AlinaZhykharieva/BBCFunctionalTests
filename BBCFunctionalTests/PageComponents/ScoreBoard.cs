using OpenQA.Selenium;
using System;
using BBCFunctionalTests.Driver;

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
    public class ScoreBoard
    {

        public Score GetScore(string team1, string team2)
        {
           
            IWebElement ActualFirstTeam = DriverInstance.Current.FindElement(By.XPath("//span[text()[contains(.,'" + team1 + "')]]"));
            IWebElement ActualSecondTeam = DriverInstance.Current.FindElement(By.XPath("//span[text()[contains(.,'" + team2 + "')]]"));

            ChampionshipPage championshipPage = new ChampionshipPage(DriverInstance.Current);

            if (ActualFirstTeam.Text.Contains(team1) && (ActualSecondTeam.Text.Contains(team2)))
            {

                return new Score(championshipPage.GetActualNumberOfGoalsScoredByTheFirstTeam(team1, team2), championshipPage.GetActualNumberOfGoalsScoredByTheSecondTeam(team1, team2));

            }
            else
            {
                
                throw new ArgumentException("Please, Enter valid name of teams");
            }



        }

    }

}
