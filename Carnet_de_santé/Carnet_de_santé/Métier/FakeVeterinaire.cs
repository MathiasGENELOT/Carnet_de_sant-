using System;
using System.Collections.Generic;
using System.Text;

namespace Carnet_de_santé
{
    class FakeVeterinaire : stockageVeterinaire
    {
        public Veterinaire load()
        {
            Veterinaire v = new Veterinaire();
            v.Adresse = "100 rue des charrières";
            v.Mail = "Mathiasgenelot@iut-dijon.u-bourgogne.fr";
            v.Nom = "Mathias GENELOT";
            v.Telephone = "0781508894";
            return v;
        }

        public void save(Veterinaire veterinaire)
        {
        }
    }
}
