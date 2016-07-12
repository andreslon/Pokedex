using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Cross.Utils
{
    public class HttpService
    {
        public string jsonUri { get; set; } = "http://andreslonstorage.blob.core.windows.net/files/pokemons.json";
        public async Task<HttpResponseMessage> GetPokemonsAsync()
        {
            HttpResponseMessage result = new HttpResponseMessage();
            using (var client = new HttpClient())
            {
                result = await client.GetAsync(jsonUri);
            }
            return result;
        }
    }
}
