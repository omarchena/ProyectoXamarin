using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProyectoCenfotec.Models;
namespace ProyectoCenfotec.Service
{
    public class WikiaService : ServiceBase
    {

        /// <summary>
        /// Buscar un tema en wiki
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<WikiaModel.WikiaResultSet> Read(string name = "")
        {
            return await Get<WikiaModel.WikiaResultSet>($"ByString?expand=1&string={name}&limit=25&batch=1&includeDomain=true");
        }

        /// <summary>
        /// Buscar detalle de tema en wiki por id
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<WikiaInformacion.prueba> ReadDetail(string id = "")
        {
            return await GetDetails<WikiaInformacion.prueba>($"Details?ids={id}");
        }

        /// <summary>
        /// Buscar detalle de tema en wiki por id
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<WikiTops.UnexpandedWikiaResultSet> ReadByHub(string hub = "")
        {
            return await GetByHub<WikiTops.UnexpandedWikiaResultSet>($"List?hub={hub}&limit=25&batch=1");
        }

        public async Task<WikiUsuarios.UserResultSet> GetDetailsUser(int userid = 0)
        {
            return await GetDetailsUser<WikiUsuarios.UserResultSet>($"Details?ids={userid}");
        }

    }
}
