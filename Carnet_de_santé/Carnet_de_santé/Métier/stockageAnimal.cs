using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carnet_de_santé
{
    public interface stockageAnimal
    {
        /// <summary>
        /// Permet de sauvegarder un Animal 
        /// </summary>
        /// <param name="n">Animal</param>
        void save(Animal animal);

        /// <summary>
        /// Permet de charger un Animal 
        /// </summary>
        /// <returns>retourne un Animal</returns>
        Animal load();

    }
}
