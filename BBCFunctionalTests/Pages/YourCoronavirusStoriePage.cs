using BBCFunctionalTests.Driver;
using BBCFunctionalTests.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class YourCoronavirusStoriePage: BasePage
    {
        public YourCoronavirusStoriePage(IWebDriver driver): base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'How to share')]/parent::a")]
        private readonly IWebElement LinkHowToShareWithBBCNews;


        public void ClickOnLinkHowToShareWithBBCNews() 
        {
            Utilities.Waits.WaitForLoad();
            LinkHowToShareWithBBCNews.Click();
           
        }

    }
   

}
