using Pokedex.Cross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Pokedex.Cross.Views
{
    public partial class PokedexPage : ContentPage
    {
        public PokedexPage()
        {
            InitializeComponent();
            BindingContext = new PokedexViewModel();
        }
    }
}
