﻿using BBCFunctionalTests.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BBCFunctionalTests
{
    public class BaseTest
    {
        

       

        private readonly string BBC_URL = "https://www.bbc.com";

        [SetUp]
        public  void Initialize()
        {
            DriverInstance.Init();
            DriverInstance.Current.Url = BBC_URL;
          

        }
        [TearDown]
        public void CleanUp()
        {
            DriverInstance.Current.Close();

        }
        
    }
    
}
