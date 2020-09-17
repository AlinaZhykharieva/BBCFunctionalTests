using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCFunctionalTests.Pages
{
    public class CoronavirusPage:BasePage
    {
        public CoronavirusPage(IWebDriver driver): base (driver)
        {

        }
        
        [FindsBy(How = How.XPath, Using = "//nav[@class='nw-c-nav__wide-secondary']//a[contains(@href, 'have_your_say')]")]
        private IWebElement LinkYourCoronavirusStories;


        public YourCoronavirusStoriePage ClickLinkYourCoronavirusStories() 
        {
            WaitForLoad(DriverInstance.Current);
            LinkYourCoronavirusStories.Click();
            return new YourCoronavirusStoriePage(DriverInstance.Current);
        }

    }
}
