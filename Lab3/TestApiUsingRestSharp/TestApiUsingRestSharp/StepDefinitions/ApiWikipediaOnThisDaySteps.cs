using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;

namespace TestApiUsingRestSharp.StepDefinitions
{

    [Binding]
    public class ApiTestingSteps
    {
        private RestClient client;
        private RestRequest request;
        private IRestResponse response;
        private const string baseUrl = "https://byabbe.se/on-this-day/";
        public ApiTestingSteps()
        {
            client = new RestClient(baseUrl);
        }

        [Given(@"Create Get a list of events request ""(.*)""")]
        public void CreateGetAllRequest(string endpoint)
        {
            request = new RestRequest(endpoint, Method.GET);
        }

        [When(@"Send a Get a list of events request")]
        public void WhenSendAGetAllRequest()
        {
            response = client.Execute(request);
        }

        [Then(@"the Get a list of events response status code should be (.*)")]
        public void ThenTheGETALlResponseStatusCodeShouldBe(int expectedStatusCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.AreEqual(expectedStatusCode, actualStatusCode, $"Expected status code {expectedStatusCode}, but got {actualStatusCode}");
        }

        [Then(@"the response should contain the list of events")]
        public void ThenTheResponseShouldContainTheListOfEvents()
        {
            JObject museumDetails = JObject.Parse(response.Content);
            Assert.IsNotNull(museumDetails, "list IDs not found in the response");
        }
        //----------------------------------------------------------------------------

        [Given(@"create Get a list of deaths request ""(.*)""")]
        public void CreateGetListOfDeathRequest(string endpoint)
        {
            request = new RestRequest(endpoint, Method.GET);
        }

        [When(@"Send a Get a list of deaths request")]
        public void WhenSendAGetListOfDeathRequest()
        {
            response = client.Execute(request);
        }

        [Then(@"the Get a list of deaths response status code should be (.*)")]
        public void ThenTheGETListOfDeathResponseStatusCodeShouldBe(int expectedStatusCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.AreEqual(expectedStatusCode, actualStatusCode, $"Expected status code {expectedStatusCode}, but got {actualStatusCode}");
        }

        [Then(@"the response should contain then list of deaths")]
        public void ThenTheResponseShouldContainTheListOfDeath()
        {
            JObject museumDetails = JObject.Parse(response.Content);
            Assert.IsNotNull(museumDetails, "List Of Death ID not found in the response");
        }
        //-------------------------------------------------------------
        [Given(@"create Get a list of births request ""(.*)""")]
        public void CreateGetListOfBirthRequest(string endpoint)
        {
            request = new RestRequest(endpoint, Method.GET);
        }

        [When(@"Send a Get a list of births request")]
        public void WhenSendAGetListOfBirthRequest()
        {
            response = client.Execute(request);
        }

        [Then(@"the Get a list of births response status code should be (.*)")]
        public void ThenTheGETListOfBirthResponseStatusCodeShouldBe(int expectedStatusCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.AreEqual(expectedStatusCode, actualStatusCode, $"Expected status code {expectedStatusCode}, but got {actualStatusCode}");
        }

        [Then(@"the response should contain the list of births")]
        public void ThenTheResponseShouldContainTheListOfBirth()
        {
            JObject museumDetails = JObject.Parse(response.Content);
            Assert.IsNotNull(museumDetails, "List Of Birth IDs not found in the response");
        }
    }
}
