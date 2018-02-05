using System.Collections.Generic;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Remote
{
    public interface IApiClient
    {
        IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly, int pageNumber, int perPage);

        IEnumerable<Vacancy> Search(SearchData searchData, out long totalItemsCount, bool activeOnly, int pageNumber, int perPage);
    }
}
