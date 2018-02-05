using System.Collections.Generic;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Remote
{
    public interface IApiClient
    {
        IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly, int pageNumber = 0, int perPage = 20);

        IEnumerable<Vacancy> Search(SearchData searchData, out long totalItemsCount, bool activeOnly, int pageNumber = 0, int perPage = 20);
    }
}
