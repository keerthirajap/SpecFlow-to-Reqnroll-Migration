using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace BDDTesting.Net7.StepDefinitions
{
    [Binding]
    public class CheckCSharpCornerArticleSteps
    {
        private readonly IWebDriver _driver;

        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;

        public CheckCSharpCornerArticleSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
            _driver = new ChromeDriver();
        }

        [Given(@"I navigate to the C-Sharp Corner article page ""([^""]*)""")]
        public void GivenINavigateToTheC_SharpCornerArticlePage(string url)
        {
            _driver.Navigate().GoToUrl("https://www.c-sharpcorner.com/article/insight-database-write-less-code-in-data-access-layer-using-auto-interface-imp/");
        }

        [When(@"the page has successfully loaded")]
        public void WhenThePageHasSuccessfullyLoaded()
        {
            // Example check: Wait until the header is present
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(driver => driver.FindElement(By.TagName("h1")).Displayed);
        }

        [Then(@"I should see the header ""(.*)""")]
        public void ThenIShouldSeeTheHeader(string expectedHeader)
        {
            var header = _driver.FindElement(By.TagName("h1")).Text;
            Assert.AreEqual(expectedHeader, header);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}