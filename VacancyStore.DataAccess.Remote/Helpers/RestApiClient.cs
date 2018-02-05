using RestSharp;
using System;

namespace VacancyStore.DataAccess.Remote.Helpers
{
    public class RestApiClient
    {
        private string _baseUrl;

        public RestApiClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public string Execute(RestRequest request)
        {
            var client = new RestClient();
            client.BaseUrl = new System.Uri(_baseUrl);
            var response = client.Execute(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                throw new ApplicationException(message, response.ErrorException);
            }
            return response.Content;
        }
    }
}
