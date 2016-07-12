using Newtonsoft.Json;
using Pokedex.Cross.Models;
using Pokedex.Cross.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Cross.ViewModels
{
    public class PokedexViewModel
    {
        public List<Pokemon> Pokemons { get; set; }
        public PokedexViewModel()
        {
            LoadPokemons();
        }

        private async void LoadPokemons()
        {
            try
            {
                HttpService service = new HttpService();
                var result = await service.GetPokemonsAsync();
                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();
                    Pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(content);
                }
            }
            catch (Exception ex)
            {
             
            }
            
        }
    }
}
