
using BBCFunctionalTests.Driver;
using BBCFunctionalTests.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;



namespace BBCFunctionalTests
{
     public class NewsPage: BasePage
     {
        public NewsPage(IWebDriver driver): base(driver)
        {

        }
        

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='close']")]
        private IWebElement ButtonCloseOnPopUpWithProposeOfSabscription;

        [FindsBy(How = How.XPath, Using = "//div[@class='gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//a//h3")]
        private IWebElement ActualTitleOfMainArticleOnHomePage;

        [FindsBy(How = How.XPath, Using = "//div[@class='gs-c-promo nw-c-promo gs-o-faux-block-link gs-u-pb gs-u-pb+@m nw-p-default gs-c-promo--inline gs-c-promo--stacked@m nw-u-w-auto gs-c-promo--flex']//a[@class='gs-c-promo-heading gs-o-faux-block-link__overlay-link gel-pica-bold nw-o-link-split__anchor']")]
        IList<IWebElement> secondaryArticleTitle;

        [FindsBy(How = How.XPath, Using = "//div[@data-entityid='container-top-stories#1' ]//li[@class = 'nw-c-promo-meta']//span")]
        private IWebElement TagName;

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        private IWebElement SearchInputOnNewsPage;

        [FindsBy(How = How.XPath, Using = "//button[@id='orb-search-button']")]
        private IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'news/coronavirus')]")]
        private IWebElement MenuCoronavirus;


       

        public void ClickOnButtonCloseOnPopUpWithProposeOfSabscription()
        {
       
           ButtonCloseOnPopUpWithProposeOfSabscription.Click();
            
        }

        public string GetActualTitleOfMainArticleOnHomePage()
        {
            return ActualTitleOfMainArticleOnHomePage.Text;
        }
        public IList<IWebElement> GetSecondaryArticleTitle()
        {
            return secondaryArticleTitle;
        }

        public string GetTagName()
        {
            return TagName.Text;

        }

        public void SendKeysInSearchInputOnNewsPage()
        {
            WaitForLoad(DriverInstance.Current);
            SearchInputOnNewsPage.SendKeys(GetTagName());
            WaitForLoad(DriverInstance.Current);
            SearchButton.Click();
           
            
        }
        

        //public void ClickOnSearchButton() 
        //{
        //    SearchButton.Click();
        //}

        public CoronavirusPage ClickOnMenuCoronavirus()
        {
            WaitForLoad(DriverInstance.Current);
            MenuCoronavirus.Click();
            return new CoronavirusPage(DriverInstance.Current);
        }


    }
}
