using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BBCFunctionalTests
{
     public class HomePage:BasePage
     {
        public HomePage(IWebDriver driver) : base(driver)
        { 
            
        }
        
        [FindsBy(How = How.XPath, Using = "//div[@id='orb-nav-links']//li[@class='orb-nav-newsdotcom']/a")]
        public IWebElement MenuNews;
       
        [FindsBy(How = How.XPath, Using = "//div[@class='orb-nav-section orb-nav-links orb-nav-focus']//li[@class ='orb-nav-sport']/a")]
        public IWebElement MenuSportInNavBar;
        public NewsPage ClickOnMenuNews()
        {
            WaitForLoad(DriverInstance.Current, 15);
            MenuNews.Click();
            WaitForLoad(DriverInstance.Current, 15);
            return new NewsPage(DriverInstance.Current);
        }

        public SportPage ClickOnMenuSportInNavBar()
        {
            WaitForLoad(DriverInstance.Current, 15);
            MenuSportInNavBar.Click();
            WaitForLoad(DriverInstance.Current, 15);
            return new SportPage(DriverInstance.Current);
        }




    }
}
