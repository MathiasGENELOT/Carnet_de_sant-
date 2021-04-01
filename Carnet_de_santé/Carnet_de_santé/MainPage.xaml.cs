using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carnet_de_santé
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnAnimalClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Animal_Page());
        }
        async void OnVeterinaireClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Veterinaire_Page());
        }

        async void OnVaccinClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Vaccin_Page());
        }
    }
}
