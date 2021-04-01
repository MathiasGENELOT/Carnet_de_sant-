using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace Carnet_de_santé
{
    public class FakeAnimal : stockageAnimal

    {
        public Animal load()
        {
            Animal a = new Animal();
            a.Nom = "boufi";
            a.Espece = "Malinois";
            a.Image = "chien.png";
            a.NumeroID = "A5BN45KE";
            a.Race = "chien";
            a.Sexe = "Male";
            a.Date = DateTime.Now;

            return a;
        }

        public void save(Animal animal)
        {
        }
    }
}
