using BBCFunctionalTests.Driver;


namespace BBCFunctionalTests
{
    class BusinessLogicLayer:BaseTest
    {
        
        
        public ScoresAndFixturesPage GoToTheFootballScoresAndFixtures()
        {
            HomePage homePage = new HomePage(DriverInstance.Current);
            homePage.ClickOnMenuSportInNavBar().ClickOnButtonCloseOnPopUpWithProposeOfSabscription().ClickOnMenuFootball().ClickOnMenuScoresAndFixturesOnFootballPage();
            return new ScoresAndFixturesPage(DriverInstance.Current);

        }
        public void GoToHowToShareWithBBCNews() 
        {
            HomePage homePage = new HomePage(DriverInstance.Current);
            homePage.ClickOnMenuNews().ClickOnButtonCloseOnPopUpWithProposeOfSabscription()
            .ClickOnMenuCoronavirus().ClickLinkYourCoronavirusStories().ClickOnLinkHowToShareWithBBCNews();
             

        }
    }
}
