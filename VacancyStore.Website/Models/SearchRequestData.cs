namespace VacancyStore.Website.Models
{
    public class SearchRequestData
    {
        public string SearchString { get; set; }
        public long? SalaryFrom { get; set; }
        public bool VacancyNameSearchEnable { get; set; }
        public bool VacancyDescSearchEnable { get; set; }
        public bool EmployerSearchEnable { get; set; }
    }
}