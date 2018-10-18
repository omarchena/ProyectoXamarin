using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCenfotec.Service
{
    public class PokemonsService : ServiceBase
    {
        public async Task<List<ProyectoCenfotec.Models.PokemonsModel>> Read(string name = "")
        {
            return await Get<List<ProyectoCenfotec.Models.PokemonsModel>>($"Product?name={name}");
        }
    }
}
