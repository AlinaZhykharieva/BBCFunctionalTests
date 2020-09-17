using BBCFunctionalTests.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BBCFunctionalTests.Steps
{
    [Binding]
    public class TitleOfArticlesOnNewsPageSteps
    {
        [When(@"I go to the News Page")]
        public void WhenIGoToTheNewsPage()
        {
            HomePage homePage = new HomePage(DriverInstance.Current);
            homePage.ClickOnMenuNews();
        }
        
        [Then(@"the title of main article should be ""(.*)""")]
        public void ThenTheTitleOfMainArticleShouldBe(string expectedTitleOfMainArticleOnNewsPage)
        {
            NewsPage newsPage = new NewsPage(DriverInstance.Current);
            Assert.IsTrue(newsPage.GetActualTitleOfMainArticleOnHomePage().Contains(expectedTitleOfMainArticleOnNewsPage));
        }
        [Then(@"the titles of secondary articles should be:")]
        public void ThenTheTitlesOfSecondaryArticlesShouldBe(Table table)
        {
            List<string> expectedsecondaryTitles = (List<string>)(from row in table.Rows select row["Titles"]);

            NewsPage newsPage = new NewsPage(DriverInstance.Current);
            List<string> secondaryTitlesString = new List<string>();

            foreach (IWebElement webElement in newsPage.GetSecondaryArticleTitle())
            {
                string textsecondaryTitlesString = webElement.Text;
                secondaryTitlesString.Add(textsecondaryTitlesString);
            }
            for (int i = 0; i < secondaryTitlesString.Count; i++)
            {
                Assert.IsTrue(secondaryTitlesString.Contains(expectedsecondaryTitles[i]));
            }
            

        }
        
        



    }
}
