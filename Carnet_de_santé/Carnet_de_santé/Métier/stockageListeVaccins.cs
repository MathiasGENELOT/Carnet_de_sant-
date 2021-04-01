using System;
using System.Collections.Generic;
using System.Text;

namespace Carnet_de_santé
{
    interface stockageListeVaccins
    {
        /// <summary>
        /// Permet de sauvegarder une liste de vaccin 
        /// </summary>
        /// <param name="n">ListeVaccins</param>
        void save(ListeVaccins vaccins);

        /// <summary>
        /// Permet de charger une liste de vaccin 
        /// </summary>
        /// <returns>retourne une ListeVaccins</returns>
        ListeVaccins load();

    }
}
