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

        public IEnumerable<Vacancy> Get(long offset = 0, long? amount = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vacancy> Search(string vacancyName, string employerName, long? salaryFrom, long offset = 0, long? amount = null)
        {
            throw new NotImplementedException();
        }

    }
}
