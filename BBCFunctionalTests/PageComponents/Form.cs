using BBCFunctionalTests.Driver;
using BBCFunctionalTests.Utilities;
using OpenQA.Selenium;
using System.Collections.Generic;


namespace BBCFunctionalTests
{
    public class Form
    {
        
        public void FillForm(Dictionary<string, string> values)
        {
            IWebElement buttonSubmit = DriverInstance.Current.FindElement(By.XPath("//button[@class='button']"));

            Waits.WaitForLoad();
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
            buttonSubmit.Click();
           

        }


    }
}
