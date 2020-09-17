using BBCFunctionalTests.Driver;
using BBCFunctionalTests.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
namespace BBCFunctionalTests.Pages
{
    public class HowToShareWithBBCNewsPage: BasePage
    {
        public HowToShareWithBBCNewsPage(IWebDriver driver): base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//div[@class= 'input-error-message']")]
        IList<IWebElement> ListOfErrorMessages;


        public IList<IWebElement> GetListOfErrorMessages()
        {
            WaitForLoad(DriverInstance.Current);
            return ListOfErrorMessages;
        }
    }
}
