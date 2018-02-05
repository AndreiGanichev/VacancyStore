using System;
using System.Collections.Generic;
using VacancyStore.DataAccess.Common.Models;
using VacancyStore.DataAccess.Remote;

namespace VacancyStore.DataAccess.Repositories
{
    public class RemoteRepository : IVacancyRepository
    {
        private IApiClient _apiClient;

        public RemoteRepository(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly, int pageNumber = 0, int perPage = 20)
        {
            return _apiClient.Get(out totalItemsCount, activeOnly, pageNumber, perPage);
        }

        public IEnumerable<Vacancy> Search(SearchData searchData, out long totalItemsCount, bool activeOnly, int pageNumber = 0, int perPage = 20)
        {
            return _apiClient.Search(searchData, out totalItemsCount, activeOnly, pageNumber, perPage);
        }

    }
}
