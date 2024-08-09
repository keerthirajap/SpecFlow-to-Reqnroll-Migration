namespace BDDTesting.Net7.Hooks
{
    using BDDTesting.Net7.Services;
    using Microsoft.Extensions.DependencyInjection;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TechTalk.SpecFlow;

    [Binding]
    public class Hooks
    {
        private readonly ILoggerService _logger;
        private readonly IServiceScope _serviceScope;
        private readonly ScenarioContext _scenarioContext;
        private readonly FeatureContext _featureContext;

        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            //// Initialize the service provider and create a service scope
            TestServiceProvider.ConfigureServices();
            _serviceScope = TestServiceProvider.ServiceProvider.CreateScope();
            _logger = _serviceScope.ServiceProvider.GetRequiredService<ILoggerService>();

            // Inject ScenarioContext and FeatureContext
            _scenarioContext = scenarioContext;
            _featureContext = featureContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            // Configure services for dependency injection
            TestServiceProvider.ConfigureServices();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _logger.Log("Starting scenario: " + ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _serviceScope.Dispose(); // Dispose the service scope
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // No need to dispose of ServiceProvider here
        }
    }
}