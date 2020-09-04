using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumExtras.PageObjects;
using System.Data;
using System.Text;

namespace BBCFunctionalTests
{
     public class BasePage
     {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }
        public void WaitForLoad(IWebDriver driver, int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

    }
}
