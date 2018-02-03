
namespace VacancyStore.DataAccess.Common.Models
{
    public class Salary
    {
        public decimal? From { get; set; }

        public decimal? To { get; set; }

        public string Currency { get; set; }

        public bool IsGross { get; set; }
    }
}
