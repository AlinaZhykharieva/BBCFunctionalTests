using BBCFunctionalTests.Driver;


namespace BBCFunctionalTests
{
    class BusinessLogicLayer:BaseTest
    {
        
        
        public void GoToTheFootballScoresAndFixtures()
        {
            HomePage homePage = new HomePage(DriverInstance.Current);
            homePage.ClickOnMenuSportInNavBar().ClickOnButtonCloseOnPopUpWithProposeOfSabscription().ClickOnMenuFootball().ClickOnMenuScoresAndFixturesOnFootballPage();
         

        }
        public void GoToHowToShareWithBBCNews() 
        {
            HomePage homePage = new HomePage(DriverInstance.Current);
            NewsPage newsPage = new NewsPage(DriverInstance.Current);
            homePage.ClickOnMenuNews().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            newsPage.ClickOnMenuCoronavirus().ClickLinkYourCoronavirusStories().ClickOnLinkHowToShareWithBBCNews();
             

        }
    }
}
