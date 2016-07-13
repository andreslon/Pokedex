using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using Pokedex.Cross.Models;
using Pokedex.Cross.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pokedex.Cross.ViewModels
{
    public class PokedexViewModel : ViewModelBase
    {
        private List<PokemonViewModel> _Pokemons;
        public List<PokemonViewModel> Pokemons
        {
            get { return _Pokemons; }
            set { Set(ref _Pokemons, value); }
        }
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
                    var pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(content);
                    Pokemons = new List<PokemonViewModel>();
                    foreach (var pokemon in pokemons)
                    {
                        Pokemons.Add(new PokemonViewModel
                        {
                            name = pokemon.name,
                            species = pokemon.species,
                            image = $"{pokemon.name}.jpg"
                        });
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }


    }
}
