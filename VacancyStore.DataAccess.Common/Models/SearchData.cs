
namespace VacancyStore.DataAccess.Common.Models
{
    /// <summary>
    /// Содержит параметры для поиска
    /// </summary>
    public class SearchData
    {
        public string SearchString { get; set; }
        public long? SalaryFrom { get; set; }
        public bool VacancyNameSearchEnable { get; set; }
        public bool VacancyDescSearchEnable { get; set; }
        public bool EmployerSearchEnable { get; set; }
    }
}
