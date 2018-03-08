using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace GOGStoreQuery
{
    public static class Query
    {
        public static Models.Response Search(string gameName, int limit = 20)
        {
            if (limit > 50)
                throw new Exception("Limit cannot exceed 50.");
            string jsonStr = new WebClient().DownloadString($"https://www.gog.com/games/ajax/filtered?limit={limit}&search={WebUtility.UrlEncode(gameName)}");
            return JsonConvert.DeserializeObject<Models.Response>(jsonStr);
        }

        public async static Task<Models.Response> SearchAsync(string gameName, int limit = 20)
        {
            if (limit > 50)
                throw new Exception("Limit cannot exceed 50.");
            string jsonStr = await getAsync($"https://www.gog.com/games/ajax/filtered?limit={limit}&search={WebUtility.UrlEncode(gameName)}");
            return JsonConvert.DeserializeObject<Models.Response>(jsonStr);
        }

        private async static Task<string> getAsync(string url)
        {
            var request = WebRequest.CreateHttp(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            var response = (HttpWebResponse)(await request.GetResponseAsync());
            using (var reader = new StreamReader(response.GetResponseStream()))
                return reader.ReadToEnd();
        }
    }
}
