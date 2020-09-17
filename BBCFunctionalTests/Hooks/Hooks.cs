using BBCFunctionalTests.Driver;
using TechTalk.SpecFlow;

namespace BBCFunctionalTests.Hooks
{
    [Binding]
    class Hooks
    {
        private readonly string BBC_URL = "https://www.bbc.com";
        [BeforeScenario]
        public void Initialize()
        {
            DriverInstance.Init();
            DriverInstance.Current.Url = BBC_URL;


        }
        [AfterScenario]
        public void CleanUp()
        {
            DriverInstance.Current.Close();

        }

    }
}
