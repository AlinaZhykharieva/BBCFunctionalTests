using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBCFunctionalTests
{
    public class SearchPage: BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement TitleArticle => driver.FindElement(By.XPath("//ul[@class='css-1lb37cz-Stack e1y4nx260']/li[1]//a"));


        public string GetTitleArticle()
        {
            return TitleArticle.Text;
        }
    }
}
