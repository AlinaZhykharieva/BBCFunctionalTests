using BBCFunctionalTests.Driver;
using BBCFunctionalTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BBCFunctionalTests.Steps
{
    [Binding]
    public class CheckFormOnYourCoronavirusStoryPageSteps
    {
        [When(@"I go to the page where the form is located")]
        public void WhenIGoToThePageWhereTheFormIsLocated()
        {
            HomePage homePage = new HomePage(DriverInstance.Current);
            NewsPage newsPage = new NewsPage(DriverInstance.Current);
            homePage.ClickOnMenuNews().ClickOnButtonCloseOnPopUpWithProposeOfSabscription();
            newsPage.ClickOnMenuCoronavirus().ClickLinkYourCoronavirusStories().ClickOnLinkHowToShareWithBBCNews();
        }
        
        [When(@"I fill form with the data and send it to server")]
        public void WhenIFillFormWithTheDataAndSendItToServer(Table table)
        {
            var storyToBBCWithNameFieldBlank = table.Rows.ToDictionary(r => r[0], r => r[1]);
            Form form = new Form(DriverInstance.Current);
            form.FillForm(storyToBBCWithNameFieldBlank);
        }
        
        [Then(@"error message are displayed")]
        public void ThenErrorMessageAreDisplayed()
        {
            HowToShareWithBBCNewsPage howToShareWithBBCNewsPage = new HowToShareWithBBCNewsPage(DriverInstance.Current);
            IList<IWebElement> ListErrorMessages = howToShareWithBBCNewsPage.GetListOfErrorMessages();
            Assert.IsTrue(ListErrorMessages.Any());
            
        }
    }
}
