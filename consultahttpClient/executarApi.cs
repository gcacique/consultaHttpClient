using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace consultahttpClient
{
    public static class executarApi
    {
        public static readonly HttpClient _client = new HttpClient();

        public static T ConsultaVerboGet<T>(string url)
        {
            var viaCep = _client.GetAsync(url).Result;

            //if (viaCep.StatusCode != System.Net.HttpStatusCode.OK)
            //    throw new Exception("Ocorreu um erro na API:" + viaCep.Content.ReadAsStringAsync().Result);

            return JsonConvert.DeserializeObject<T>(viaCep.Content.ReadAsStringAsync().Result);
        }
    }
}
