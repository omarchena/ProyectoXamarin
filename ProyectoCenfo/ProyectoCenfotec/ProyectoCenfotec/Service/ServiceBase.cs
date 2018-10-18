using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProyectoCenfotec.Service
{
    public class ServiceBase
    {
        readonly HttpClient hc = new HttpClient() { BaseAddress = new Uri("http://www.wikia.com/api/v1/Wikis/") };
        readonly HttpClient hcUsers = new HttpClient() { BaseAddress = new Uri("http://www.wikia.com/api/v1/User/") };

        /// <summary>
        /// Obtener resultado por string
        /// </summary>
        /// <typeparam name="R"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Obtener detalles especificos de los temas
        /// </summary>
        /// <typeparam name="R"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        protected async Task<R> GetDetails<R>(string action)
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

        /// <summary>
        /// Obtener informacion por tema/hub
        /// </summary>
        /// <typeparam name="R"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        protected async Task<R> GetByHub<R>(string action)
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

        /// <summary>
        /// Obtener informacion del usuario creador
        /// </summary>
        /// <typeparam name="R"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        protected async Task<R> GetDetailsUser<R>(string action)
        {
            R result = default(R);

            try
            {
                var settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                settings.MissingMemberHandling = MissingMemberHandling.Ignore;

                HttpResponseMessage response = await hcUsers.GetAsync(action);
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
