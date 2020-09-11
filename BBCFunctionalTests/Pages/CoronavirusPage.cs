using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCFunctionalTests.Pages
{
    class CoronavirusPage:BasePage
    {
        public CoronavirusPage(IWebDriver driver): base (driver)
        {

        }
        
        [FindsBy(How = How.XPath, Using = "//nav[@class='nw-c-nav__wide-secondary']//a[contains(@href, 'have_your_say')]")]
        private IWebElement LinkYourCoronavirusStories;


        public void ClickLinkYourCoronavirusStories() 
        {
            LinkYourCoronavirusStories.Click();
        }

    }
}
