using AutoMapper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using VacancyStore.DataAccess.Common.Models;
using VacancyStore.DataAccess.Models.RemoteVacancy;
using VacancyStore.DataAccess.Remote.Helpers;
using VacancyStore.DataAccess.Remote.Responses;

namespace VacancyStore.DataAccess.Remote.HHApi
{
    public class HHApiClient : IApiClient
    {
        private RestApiClient _restApiClient;

        public HHApiClient(RestApiClient restApiClient)
        {
            _restApiClient = restApiClient;
        }

        public IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly, int pageNumber = 0, int perPage = 20)
        {
            var queryPairs = GetStandartQueryPairs(activeOnly, pageNumber, perPage);
            var queryString = RemoteHelper.ComposeQueryString(queryPairs, "vacancies");
            var request = new RestRequest(queryString, Method.GET);
            return Execute(request, out totalItemsCount);
        }

        public IEnumerable<Vacancy> Search(SearchData searchData, out long totalItemsCount, bool activeOnly, int pageNumber = 0, int perPage = 20)
        {
            var queryPairs = GetStandartQueryPairs(activeOnly, pageNumber, perPage);

            if (!string.IsNullOrWhiteSpace(searchData.SearchString)
                && (searchData.VacancyNameSearchEnable || searchData.VacancyDescSearchEnable || searchData.EmployerSearchEnable))
            {
                queryPairs.Add(new KeyValuePair<string, string>("text", searchData.SearchString));

                if (searchData.VacancyNameSearchEnable)
                {
                    queryPairs.Add(new KeyValuePair<string, string>("search_field", "name"));
                }

                if (searchData.VacancyDescSearchEnable)
                {
                    queryPairs.Add(new KeyValuePair<string, string>("search_field", "description"));
                }

                if (searchData.EmployerSearchEnable)
                {
                    queryPairs.Add(new KeyValuePair<string, string>("search_field", "company_name"));
                }
            }

            if (searchData.SalaryFrom.HasValue && searchData.SalaryFrom.Value != 0)
            {
                queryPairs.Add(new KeyValuePair<string, string>("salary", searchData.SalaryFrom.Value.ToString()));
            }

            var queryString = RemoteHelper.ComposeQueryString(queryPairs, "vacancies");
            var request = new RestRequest(queryString, Method.GET);
            return Execute(request, out totalItemsCount);
        }

        private IEnumerable<Vacancy> Execute(RestRequest request, out long totalItemsCount)
        {
            var responseData = _restApiClient.Execute(request);
            var response = JsonConvert.DeserializeObject<GetVacanciesResponse>(responseData);
            totalItemsCount = response.Found;
            return Mapper.Map<IEnumerable<ShortVacancyInfo>, IEnumerable<Vacancy>>(response.Items ?? new List<ShortVacancyInfo>());
        }

        private IList<KeyValuePair<string,string>> GetStandartQueryPairs(bool activeOnly, int pageNumber, int perPage)
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("page", pageNumber.ToString()));
            list.Add(new KeyValuePair<string, string>("perPage", perPage.ToString()));
            list.Add(new KeyValuePair<string, string>("area", "43"));//калужские вакансии

            if (activeOnly)
            {
                list.Add(new KeyValuePair<string, string>("type", "active"));
            }

            return list;
        }
    }
}
