using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoCenfotec.Service
{
    public class ServiceBase
    {
        readonly HttpClient hc = new HttpClient() { BaseAddress = new Uri("https://pokeapi.co/api/v2/") };

        protected async Task<R> Get<R>(string action)
        {
            R result = default(R);

            try
            {
                var settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                settings.MissingMemberHandling = MissingMemberHandling.Ignore;

                HttpResponseMessage response = await hc.GetAsync(action);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<R>(json, settings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return result;
        }

        ~ServiceBase()
        {
            hc.Dispose();
        }
    }
}
