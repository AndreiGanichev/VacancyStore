using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.Website.Helper
{
    public static class ViewHelper
    {
        public static string GetTotalCountSignature(long totalCount)
        {
            var result = totalCount.ToString();
            var lastSymbol = result[result.Length-1];

            switch (lastSymbol)
            {
                case '1':
                    result = $"Найдена {result} вакансия";
                    break;
                case '2':
                case '3':
                case '4':
                    result = $"Найдено {result} вакансии";
                    break;
                default:
                    result = $"Найдено {result} вакансий";
                    break;
            }
            return result;
        }

        public static string GetSalarySigniture(Salary salary)
        {
            if (salary == null)
            {
                return string.Empty;
            }

            string result = salary.From.HasValue ? $"от {salary.From.Value}" : string.Empty;
            result += salary.To.HasValue ? $" до {salary.To.Value} " : string.Empty;
            result += salary.Currency;
            return result;
        }
    }
}