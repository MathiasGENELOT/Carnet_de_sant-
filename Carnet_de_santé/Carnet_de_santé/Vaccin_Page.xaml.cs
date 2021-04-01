using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carnet_de_santé
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vaccin_Page : ContentPage
    {
        
        private stockageListeVaccins stockage = new FakeListeVaccins();
        private ListeVaccins liste;
        private VaccinsViewModel vm;
        public Vaccin_Page()
        {
            InitializeComponent();
            liste = stockage.load();
            vm = new VaccinsViewModel(liste);
            BindingContext = vm;
        }
        async void OnAjouterClicked(object sender, EventArgs args)
        {
            Vaccin v = new Vaccin();
            VaccinViewModel vvm = vm.Add(v);
            await Navigation.PushAsync(new VaccinEdit_Page(vm,vvm));
        }
    }
}