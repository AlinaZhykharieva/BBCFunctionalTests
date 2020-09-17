using BBCFunctionalTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBCFunctionalTests
{
    public class Form: BasePage
    {
        public Form(IWebDriver driver):base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//textarea[@aria-label= 'Tell us your story. ']")]
        private IWebElement TextareaForStorie;

        [FindsBy(How = How.XPath, Using = "//input[@aria-label='Name']")]
        private IWebElement InputForName;

        [FindsBy(How = How.XPath, Using = "//*[contains (text(), 'publish my name')]/ancestor::label/input")]
        private IWebElement CheckboxPleaseDontPublishMyName;

        [FindsBy(How = How.XPath, Using = "//*[contains (text(), 'Terms of Service')]/ancestor::label/input")]
        private IWebElement CheckboxIAcceptTheTermsOfService;

        [FindsBy(How = How.XPath, Using = "//*[contains (text(), 'I am over 16 years old')]/ancestor::label/input")]
        private IWebElement CheckboxIamOver16YearsOld;

        [FindsBy(How = How.XPath, Using = "  //button[@class='button']")]
        private IWebElement ButtonSubmit;
        public void FillForm(Dictionary<string, string> values)
        {
            WaitForLoad(DriverInstance.Current);
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
            WaitForLoad(DriverInstance.Current);

        }


    }
}
