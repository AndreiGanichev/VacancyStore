
namespace VacancyStore.DataAccess.Common.Models
{
    public class Vacancy : BaseIdName
    {
        public Salary Salary { get; set; }

        public Employer Employer { get; set; }

        public string Description { get; set; }

        public BaseIdName Area { get; set; }

        public string ApplyPageUrl { get; set; }
    }
}
