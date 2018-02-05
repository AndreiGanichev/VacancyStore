using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VacancyStore.DataAccess.Remote.Helpers
{
    public static class RemoteHelper
    {
        public static string ComposeQueryString(this IList<KeyValuePair<string,string>> queryPairs, string seedQuery)
        {
            var stringCollection = queryPairs.Select(p => $"{HttpUtility.UrlEncode(p.Key)}={HttpUtility.UrlEncode(p.Value)}");
            return $"{seedQuery}?{string.Join("&", stringCollection)}";
        }
    }
}
