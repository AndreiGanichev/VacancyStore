using Newtonsoft.Json;
using System.Collections.Generic;

namespace VacancyStore.DataAccess.Models.RemoteVacancy
{
    /// <summary>
    /// Адрес
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Номер дома
        /// </summary>
        public string Building { get; set; }

        /// <summary>
        /// Дополнительная информация об адресе
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Текстовое описание адреса, как было введено
        /// </summary>
        [JsonProperty("Raw")]
        public string RawAddress { get; set; }

        /// <summary>
        /// Список станций метро
        /// </summary>
        public List<MetroStation> MetroStations { get; set; }

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
