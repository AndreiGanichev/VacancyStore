using Newtonsoft.Json;
using System;
using VacancyStore.DataAccess.Common.Models;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Короткое представление вакансии
    /// </summary>
    public class ShortVacancyInfo
    {
        /// <summary>
        /// Идентификатор вакансии
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Текстовые сниппеты
        /// </summary>
        public Snippet Snippet { get; set; }

        /// <summary>
        /// Является ли данная вакансия премиум-вакансией
        /// </summary>
        [JsonProperty("premium")]
        public bool IsPremium { get; set; }

        /// <summary>
        /// Адрес вакансии
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Ссылка на представление вакансии на сайте
        /// </summary>
        [JsonProperty("alternate_url")]
        public string VacancyPageUrl { get; set; }

        /// <summary>
        /// Ссылка на отклик на вакансию на сайте
        /// </summary>
        [JsonProperty("apply_alternate_url")]
        public string ApplyPageUrl { get; set; }

        /// <summary>
        /// Департамент, от имени которого размещается вакансия
        /// </summary>
        public BaseIdName Department { get; set; }

        /// <summary>
        /// Оклад
        /// </summary>
        public Salary Salary { get; set; }

        /// <summary>
        /// Название вакансии
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Регион размещения вакансии
        /// </summary>
        public Area Area { get; set; }

        /// <summary>
        /// Ссылка на api для получение полной информации по вакансии
        /// </summary>
        [JsonProperty("url")]
        public string FullInfoApiUrl { get; set; }

        /// <summary>
        /// Дата и время публикации вакансии
        /// </summary>
        [JsonProperty("published_at")]
        public DateTime PublishedAt { get; set; }

        /// <summary>
        /// Дата и время публикации вакансии
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Короткое представление работодателя
        /// </summary>
        public Employer Employer { get; set; }

        /// <summary>
        /// Обязательно ли заполнять сообщение при отклике на вакансию
        /// </summary>
        [JsonProperty("response_letter_required")]
        public bool IsResponseLetterRequired { get; set; }

        /// <summary>
        /// Тип вакансии
        /// </summary>
        public BaseIdName Type { get; set; }

        /// <summary>
        /// Находится ли вакансия в архиве
        /// </summary>
        [JsonProperty("archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Расстояние в метрах между центром сортировки(указывается в запросе при сортировке по удалённости от гео-точки ) 
        /// и указанным в вакансии адресом.
        /// </summary>
        public int? FromSortPointDistance { get; set; }
    }
}
