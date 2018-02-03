using Newtonsoft.Json;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Станция метро
    /// </summary>
    public class MetroStation
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonProperty("station_id")]
        public string Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("station_name")]
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор линии метро, на которой находится станция
        /// </summary>
        [JsonProperty("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// Название линии метро, на которой находится станция
        /// </summary>
        [JsonProperty("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// Географическая широта
        /// </summary>
        [JsonProperty("lat")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Географическая долгота
        /// </summary>
        [JsonProperty("lng")]
        public double? Longitude { get; set; }
    }
}
