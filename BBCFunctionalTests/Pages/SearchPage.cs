using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BBCFunctionalTests
{
    public class SearchPage: BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {

        }
        [FindsBy(How = How.XPath, Using = "//ul[@class='css-1lb37cz-Stack e1y4nx260']/li[1]//a")]
        private readonly IWebElement TitleArticle;


        public string GetTitleArticle()
        {
            return TitleArticle.Text;
        }
    }
}
