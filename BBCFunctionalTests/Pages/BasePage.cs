using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using OpenQA.Selenium.Chrome;
using BBCFunctionalTests.Driver;

namespace BBCFunctionalTests
{
     public class BasePage
     {

        private IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void WaitForLoad(IWebDriver driver, int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
        public void ImplicityWait(long timeout) 
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }
        //public void WaitForElementWisibility(int timeout, IWebElement element)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeout));
        //    wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By)element));
        //}
        
    }
}
