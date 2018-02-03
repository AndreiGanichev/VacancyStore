using AutoMapper;
using RestSharp;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Vacancy> Get(bool activeOnly = true, int pageNumber = 0, int perPage = 20)
        {
            //TODO: подумать как красивее формирвоать запросы
            var queryString = $"vacancies?page={pageNumber}&perPage={perPage}";
            
            if (activeOnly)
            {
                queryString += "&type=active";
            }

            var request = new RestRequest(queryString, Method.GET);
            var response = _restApiClient.Execute<GetVacanciesResponse>(request);
            return Mapper.Map<IEnumerable<ShortVacancyInfo>, IEnumerable<Vacancy>>(response.Items);
        }

        public IEnumerable<Vacancy> Search(string vacancyName, string employerName, long? salaryFrom, bool activeOnly = true, int pageNumber = 0, int perPage = 20)
        {
            throw new NotImplementedException();
        }
    }
}
