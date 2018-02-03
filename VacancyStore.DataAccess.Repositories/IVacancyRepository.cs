using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Repositories
{
    public interface IVacancyRepository
    {
        IEnumerable<Vacancy> Get(long offset = 0, long? amount = null);

        IEnumerable<Vacancy> Search(string vacancyName, string employerName, long? salaryFrom, long offset = 0, long? amount = null);
    }
}
