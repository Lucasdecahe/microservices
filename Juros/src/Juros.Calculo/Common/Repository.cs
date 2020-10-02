using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Juros.Calculo.Common
{
    public class Repository : IRepository
    {
        private static string baseUrl = "http://localhost:63806";

    public async Task<double> GetTaxaAsync()
        {
            var taxaJson = await GetStringAsync(baseUrl + "/taxaJuros");

            var taxa = JsonConvert.DeserializeObject<double>(taxaJson);

            return taxa;
        }

        private static async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return httpClient.GetStringAsync(url).Result;
            }
        }
    }
}
