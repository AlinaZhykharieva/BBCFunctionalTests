using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace BBCFunctionalTests.Driver
{
    public static class DriverInstance
    {
        private static IWebDriver driver;

        public static void Init() 
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }
        public static IWebDriver Current => driver ?? throw new NullReferenceException("driver does not exist");




        
    }
}
