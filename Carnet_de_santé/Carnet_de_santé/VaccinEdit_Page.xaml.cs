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
    public partial class VaccinEdit_Page : ContentPage
    {
        private VaccinViewModel vaccin;
        private VaccinsViewModel liste;
        public VaccinEdit_Page(VaccinsViewModel l, VaccinViewModel v)
        {
            vaccin = v;
            liste = l;
            BindingContext = vaccin;
            InitializeComponent();
        }
    }
}