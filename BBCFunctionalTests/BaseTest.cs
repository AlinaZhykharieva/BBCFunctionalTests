using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBCFunctionalTests
{
    public class BaseTest
    {
        public IWebDriver driver;
        private string BBC_URL = "https://www.bbc.com";

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(BBC_URL);
            driver.Manage().Window.Maximize();

        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();

        }
        public IWebDriver GetDriver()
        {
            return driver;
        }

        public BasePage GetBasePage()
        {
            return new BasePage(GetDriver());
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }
        public NewsPage GetNewsPage()
        {
            return new NewsPage(GetDriver());
        }
        public SearchPage GetSearchPage()
        {
            return new SearchPage(GetDriver());
        }
    }
    
}
