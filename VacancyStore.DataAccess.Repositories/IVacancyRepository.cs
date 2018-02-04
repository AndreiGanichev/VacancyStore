﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Repositories
{
    public interface IVacancyRepository
    {
        IEnumerable<Vacancy> Get(out long totalItemsCount, bool activeOnly = true, int pageNumber = 1, int perPage = 20);

        IEnumerable<Vacancy> Search(string vacancyName, string employerName, long? salaryFrom, out long totalItemsCount, bool activeOnly = true, int pageNumber = 1, int perPage = 20);
    }
}
