using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;


namespace BBCFunctionalTests
{
    public class Form: BasePage
    {
        public Form(IWebDriver driver):base(driver)
        {

        }
        
        [FindsBy(How = How.XPath, Using = "  //button[@class='button']")]
        private readonly IWebElement ButtonSubmit;
        public void FillForm(Dictionary<string, string> values)
        {
            Utilities.Waits.WaitForLoad();
            foreach (var pair in values) 
            {
                IWebElement element = DriverInstance.Current.FindElement(By.XPath("//*[contains(@aria-label, '" + pair.Key + "')or (following-sibling::span//p[contains(text(), '" + pair.Key + "')])]"));
                if (element.TagName == "textarea")
                {
                    element.SendKeys(pair.Value);
                }
                else if (element.TagName == "input")
                {
                    if (element.GetAttribute("type") == "text")
                    {
                        element.SendKeys(pair.Value);
                    }
                    else if (element.GetAttribute("type") == "checkbox")
                    {
                        if (pair.Value == "Yes" && !element.Selected)
                        {
                            element.Click();
                        }
                        else if (pair.Value == "No" && element.Selected)
                        {
                            element.Click();
                        }
                    }
                }
                   
            }
            ButtonSubmit.Click();
           

        }


    }
}
