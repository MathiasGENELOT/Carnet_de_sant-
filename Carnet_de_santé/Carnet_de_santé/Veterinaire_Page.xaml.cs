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
    public partial class Veterinaire_Page : ContentPage
    {
        private stockageVeterinaire stockage = new FakeVeterinaire();
        public Veterinaire_Page()
        {
            InitializeComponent();
            Veterinaire v = stockage.load();
            AdresseVeto.Text =  v.Adresse;
            nomVeto.Text = v.Nom;
            MailVeto.Text = v.Mail;
            TelephoneVeto.Text = v.Telephone;
        }
    }
}