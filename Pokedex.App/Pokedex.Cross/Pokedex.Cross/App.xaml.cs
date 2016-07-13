using Pokedex.Cross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Pokedex.Cross
{
    public partial class App : Application
    {
        public static PokedexViewModel PokedexViewModel { get; set; }
        public static PokemonViewModel selectedPokemon { get; set; }
        public static NavigationPage NavigationPage { get; set; }
        public App()
        {
            InitializeComponent();
            PokedexViewModel = new PokedexViewModel();

            NavigationPage = new NavigationPage(new Pokedex.Cross.Views.PokedexPage())
            {
                BarBackgroundColor = Color.Red,
                BarTextColor = Color.White,
            };
            MainPage = NavigationPage;
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
