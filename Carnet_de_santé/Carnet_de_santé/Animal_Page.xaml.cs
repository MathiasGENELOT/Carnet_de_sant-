using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carnet_de_santé
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animal_Page : ContentPage
    {
        private Image photo = new Image();
        private stockageAnimal stockage = new FakeAnimal();
        public Animal_Page()
        {
            InitializeComponent();
            Animal a = stockage.load();

            nomAnimal.Text = a.Nom;
            raceAnimal.Text = a.Race;
            sexeAnimal.Text = a.Sexe;
            naissanceAnimal.Date = a.Date;
            IDAnimal.Text = a.NumeroID;
            especeAnimal.Text = a.Espece;
            image.Source = a.Image;     
        }
        async void TakePhoto(object sender, EventArgs args)
        {
            var result = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions()
            {
                DefaultCamera = CameraDevice.Front,
                SaveToAlbum = false
            });
            if(result!= null)
            { 
                var stream = result.GetStream();
                
                photo.Source = ImageSource.FromStream(() => stream);
                image.Source = photo.Source;
            }
        }
    }
}