using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace BBCFunctionalTests.Utilities
{
    public static class Waits
    {
        
        public static void WaitForLoad()
        {
          
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverInstance.Current;
            WebDriverWait wait = new WebDriverWait(DriverInstance.Current, new TimeSpan(0, 0, 20));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
        
    }
}
