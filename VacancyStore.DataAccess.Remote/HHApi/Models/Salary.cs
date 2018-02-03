using Newtonsoft.Json;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Оклад
    /// </summary>
    public class Salary
    {
        /// <summary>
        /// Нижняя граница вилки оклада
        /// </summary>
        public decimal? From { get; set; }

        /// <summary>
        /// Верняя граница вилки оклада
        /// </summary>
        public decimal? To { get; set; }

        /// <summary>
        /// Идентификатор валюты оклада
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Признак того что оклад указан до вычета налогов
        /// </summary>
        [JsonProperty("gross")]
        public bool? IsGross { get; set; }
    }
}
