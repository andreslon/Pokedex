using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Pokedex.Cross.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pokedex.Cross.ViewModels
{
    public class PokemonViewModel : ViewModelBase
    {
        private string _id;

        public string id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        private string _image;

        public string image
        {
            get { return _image; }
            set { Set(ref _image, value); }
        }

        private string _species;

        public string species
        {
            get { return _species; }
            set { Set(ref _species, value); }
        }






        public ICommand SelectCommand { get { return new RelayCommand(Select); } }

        private void Select()
        {
            App.selectedPokemon = this;
            App.NavigationPage.PushAsync(new PokemonPage());

        }
    }
}
