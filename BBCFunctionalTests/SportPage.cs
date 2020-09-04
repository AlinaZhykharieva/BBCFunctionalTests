using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBCFunctionalTests
{
    public class SportPage: BasePage
    {
        public SportPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement MenuFutball => driver.FindElement(By.XPath("//li[@class= 'sp-c-sport-navigation__item ']/a[@data-stat-title='Football']"));


        public void ClickOnMenuFutball() 
        {
            MenuFutball.Click();
        }

    }
}
