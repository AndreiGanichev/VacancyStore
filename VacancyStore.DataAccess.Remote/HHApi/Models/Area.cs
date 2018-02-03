using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Регион
    /// </summary>
    public class Area : BaseIdName
    {
        /// <summary>
        /// Ссылка для получения информации о регионе
        /// </summary>
        public string Url { get; set; }
    }
}
