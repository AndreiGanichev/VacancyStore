using System.Collections.Generic;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Remote
{
    public interface IApiClient
    {
        IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly = true, int pageNumber = 0, int perPage = 20);

        IEnumerable<Vacancy> Search(string vacancyName, string employerName, long? salaryFrom, out long totalItemsCount, bool activeOnly = true, int pageNumber = 0, int perPage = 20);
    }
}
