using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carnet_de_santé
{
    public interface stockageVeterinaire
    {
        /// <summary>
        /// Permet de sauvegarder un Veterinaire 
        /// </summary>
        /// <param name="n">Veterinaire</param>
        void save(Veterinaire veterinaire);

        /// <summary>
        /// Permet de charger un Veterinaire 
        /// </summary>
        /// <returns>retourne un Veterinaire</returns>
        Veterinaire load();

    }
}
