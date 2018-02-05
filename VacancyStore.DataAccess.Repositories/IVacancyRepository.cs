using System.Collections.Generic;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Repositories
{
    public interface IVacancyRepository
    {
        IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly, int pageNumber = 1, int perPage = 20);

        IEnumerable<Vacancy> Search(SearchData searchData, out long totalItemsCount, bool activeOnly, int pageNumber = 1, int perPage = 20);
    }
}
