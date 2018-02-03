using Newtonsoft.Json;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Работодатель
    /// </summary>
    public class Employer : BaseIdName
    {
        /// <summary>
        /// Тип компании (прямой работодатель, кадровое агентство и т.п.)
        /// </summary>
        public BaseIdName Type { get; set; }

        /// <summary>
        /// Ссылка на официальный сайт
        /// </summary>
        [JsonProperty("site_url")]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Описание вакансии, содержит html
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Строка с кодом HTML, которая является альтернативой стандартному описанию вакансии
        /// </summary>
        [JsonProperty("branded_description")]
        public string BrandedDescription { get; set; }

        /// <summary>
        /// Ссылка на поисковую выдачу вакансий данной компании
        /// </summary>
        [JsonProperty("vacancies_url")]
        public string VacanciesUrl { get; set; }

        /// <summary>
        /// Прошла ли компания проверку на сайте
        /// </summary>
        public bool IsTrusted { get; set; }

        /// <summary>
        /// Ссылка на описание работодателя на сайте
        /// </summary>
        [JsonProperty("alternate_url")]
        public string AlternateUrl { get; set; }

        /// <summary>
        /// Изображения логотипа компании разных размеров
        /// </summary>
        public LogoUrl LogoUrl { get; set; }

        /// <summary>
        /// Регион работодателя
        /// </summary>
        public Area Area { get; set; }
    }
}
