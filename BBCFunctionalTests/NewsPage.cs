using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BBCFunctionalTests
{
     public class NewsPage: BasePage
     {
        public NewsPage(IWebDriver driver): base(driver)
        {

        }
        List<string> secondaryTitles = new List<string>
            {
                "Trump plans to visit city of Jacob Blake shooting",
                "Hundreds arrested in German 'anti-corona' protests",
                "Migrants evacuated from overloaded Banksy ship",
                "'A true superhero' - Chadwick Boseman remembered",
                "Activists topple statue of Canada's first PM"
            };

        //[FindsBy(How = How.XPath, Using = "//button[@aria-label='close']")]
        private IWebElement ButtonCloseOnPopUpWithProposeOfSabscription => driver.FindElement(By.XPath("//button[@aria-label='close']"));

        //[FindsBy(How = How.XPath, Using = "//div[@class='gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//a[@class='gs-c-promo-heading gs-o-faux-block-link__overlay-link gel-paragon-bold nw-o-link-split__anchor']")]
        private IWebElement ActualTitleOfMainArticleOnHomePage => driver.FindElement(By.XPath("//div[@class='gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//a[@class='gs-c-promo-heading gs-o-faux-block-link__overlay-link gel-paragon-bold nw-o-link-split__anchor']"));

        ReadOnlyCollection<IWebElement> secondaryArticleTitle => driver.FindElements(By.XPath("//div[@class='gs-c-promo nw-c-promo gs-o-faux-block-link gs-u-pb gs-u-pb+@m nw-p-default gs-c-promo--inline gs-c-promo--stacked@m nw-u-w-auto gs-c-promo--flex']//a[@class='gs-c-promo-heading gs-o-faux-block-link__overlay-link gel-pica-bold nw-o-link-split__anchor']"));

        private IWebElement TagName => driver.FindElement(By.XPath("//li[@class='nw-c-promo-meta']/a[@aria-label='From US & Canada']"));

        private IWebElement SearchInputOnNewsPage => driver.FindElement(By.XPath("//input[@id='orb-search-q']"));

        private IWebElement SearchButton => driver.FindElement(By.XPath("//button[@id='orb-search-button']"));


        public void ClickOnButtonCloseOnPopUpWithProposeOfSabscription()
        {
            ButtonCloseOnPopUpWithProposeOfSabscription.Click();
        }

        public string GetActualTitleOfMainArticleOnHomePage()
        {
            return ActualTitleOfMainArticleOnHomePage.Text;
        }
        //public ReadOnlyCollection<IWebElement> GetSecondaryArticleTitle()
        //{
        //    return secondaryArticleTitle;
        //}
        public bool IsSecondaryArticleTitlesOnNewsPage()
        {
            bool isSecondaryArticleTitlesOnNewsPage = false;
            List<string> secondaryTitlesString = new List<string>();
            foreach (IWebElement webElement in secondaryArticleTitle)
            {
                string textsecondaryTitlesString = webElement.Text;
                secondaryTitlesString.Add(textsecondaryTitlesString);

            }

            for (int i = 0; i < secondaryTitlesString.Count; i++)
            {
                if (secondaryTitlesString.Contains(secondaryTitles[1])) 
                {
                    isSecondaryArticleTitlesOnNewsPage = true;
                }
            }
            return isSecondaryArticleTitlesOnNewsPage;

        }

        public string GetTagName() 
        {
            return TagName.Text;
        }

        public void SendKeysInSearchInputOnNewsPage()
        {
            SearchInputOnNewsPage.SendKeys(GetTagName());
        }
        

        public void ClickOnSearchButton() 
        {
            SearchButton.Click();
        }




    }
}
