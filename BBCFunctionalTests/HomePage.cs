using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
namespace BBCFunctionalTests
{
     public class HomePage: BasePage
     {
        public HomePage(IWebDriver driver): base(driver)
        {
            
        }

        //[FindsBy(How = How.XPath, Using = "//div[@id='orb-nav-links']//li[@class='orb-nav-newsdotcom']/a")]
        //public IWebElement MenuNews { get; set; }
        public IWebElement MenuNews => driver.FindElement(By.XPath("//div[@id='orb-nav-links']//li[@class='orb-nav-newsdotcom']/a"));

        public IWebElement MenuSportInNavBar => driver.FindElement(By.XPath("//div[@class='orb-nav-section orb-nav-links orb-nav-focus']//li[@class ='orb-nav-sport']/a"));
        public void ClickOnMenuNews()
        {
            MenuNews.Click();
        }

        public void ClickOnMenuSportInNavBar()
        {
            MenuSportInNavBar.Click();
        }




    }
}
