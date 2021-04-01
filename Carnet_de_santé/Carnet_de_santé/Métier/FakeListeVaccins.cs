using System;
using System.Collections.Generic;
using System.Text;

namespace Carnet_de_santé
{
    class FakeListeVaccins : stockageListeVaccins
    {

        public void save(ListeVaccins vaccins)
        {
        }

        ListeVaccins stockageListeVaccins.load()
        {
            ListeVaccins liste = new ListeVaccins();
            Vaccin v1 = new Vaccin();
            v1.Comentaire = "comentaire 1";
            v1.Nom = "Tuberculose";
            v1.Date = DateTime.Now;
            Vaccin v2 = new Vaccin();
            v2.Comentaire = "comentaire 2";
            v2.Nom = "Sida";
            v2.Date = DateTime.Now;
            liste.add(v1);
            liste.add(v2);
            return liste;
        }
    }
}
