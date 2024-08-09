using Google.Protobuf.WellKnownTypes;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace BDDTesting.Net7.StepDefinitions
{
    [Binding]
    public class IPAddressTypeCheckStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private RestResponse _response;

        public IPAddressTypeCheckStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I send a request to check the IP address ""(.*)""")]
        public void GivenISendARequestToCheckTheIPAddress(string ipAddress)
        {
            var client = new RestClient($"https://ipapi.co/");
            var request = new RestRequest($"{ipAddress}/json/");
            _response = client.Execute(request);
        }

        [Then(@"the response should indicate that the IP address is of type ""(.*)""")]
        public void ThenTheResponseShouldIndicateThatTheIPAddressIsOfType(string expectedType)
        {
            var content = _response.Content;
            var json = JObject.Parse(content);

            var ip_type = json["ip"].ToString();
            var actualType = ip_type.Contains(":") ? "IPv6" : "IPv4";

            Assert.AreEqual(expectedType, actualType, "The IP address type does not match the expected type.");
        }
    }
}