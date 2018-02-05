using System.ComponentModel.DataAnnotations;

namespace VacancyStore.DataAccess.Common.Models
{
    /// <summary>
    /// Содержит параметры для поиска по вакансиям
    /// </summary>
    public class SearchData
    {
        public string SearchString { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage ="Вводить можно только цифры")]
        public long? SalaryFrom { get; set; }

        public bool VacancyNameSearchEnable { get; set; }

        public bool VacancyDescSearchEnable { get; set; }

        public bool EmployerSearchEnable { get; set; }
    }
}
