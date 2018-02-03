using Newtonsoft.Json;
using System.Collections.Generic;
using VacancyStore.DataAccess.Models.RemoteVacancy;

namespace VacancyStore.DataAccess.Remote.Responses
{
    public class GetVacanciesResponse
    {
        public bool? Clusters { get; set; }

        public List<ShortVacancyInfo> Items { get; set; }

        public int Pages { get; set; }

        public string Arguments { get; set; }

        public int Found { get; set; }

        [JsonProperty("alternate_url")]
        public string AlternateUrl { get; set; }

        [JsonProperty("enable_snippets")]
        public bool IsEnableSnippents { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("page")]
        public int PageNumber { get; set; }
    }
}
