using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    class YourCoronavirusStoriePage: BasePage
    {
        public YourCoronavirusStoriePage(IWebDriver driver): base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//h3[contains(text(), 'How to share')]/parent::a")]
        private IWebElement LinkHowToShareWithBBCNews;


        public void ClickOnLinkHowToShareWithBBCNews() 
        {
            LinkHowToShareWithBBCNews.Click();
        }

    }
   

}
