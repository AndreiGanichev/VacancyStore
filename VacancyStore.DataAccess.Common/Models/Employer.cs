
namespace VacancyStore.DataAccess.Common.Models
{
    public class Employer : BaseIdName
    {
        public string SiteUrl { get; set; }

        public bool IsTrusted { get; set; }

        public string LogoPath { get; set; }
    }
}
