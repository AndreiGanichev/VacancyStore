using Newtonsoft.Json;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Содержит ссылки на изображения логотипа разных размеров
    /// </summary>
    public class LogoUrl
    {
        /// <summary>
        /// Ссылка на логотип c размером 90px по меньшей стороне
        /// или ссылка на оригинал (<see cref="OriginalUrl"/>), если его размер меньше чем 90px по меньшей стороне
        /// </summary>
        [JsonProperty("90")]
        public string Size90Url { get; set; }

        /// <summary>
        /// Ссылка на логотип c размером 240px по меньшей стороне
        /// или ссылка на оригинал (<see cref="OriginalUrl"/>), если его размер меньше чем 240px по меньшей стороне
        /// </summary>
        [JsonProperty("240")]
        public string Size240Url { get; set; }

        /// <summary>
        /// Ссылка на необработанный логотип
        /// </summary>
        [JsonProperty("original")]
        public string OriginalUrl { get; set; }
    }
}
