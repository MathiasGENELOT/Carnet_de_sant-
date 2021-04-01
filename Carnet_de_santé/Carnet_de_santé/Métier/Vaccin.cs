using System;
using System.Collections.Generic;
using System.Text;

namespace Carnet_de_santé
{
    public class Vaccin
    {
        private string nom;
        /// <summary>
        /// Lit ou écrit le nom
        /// </summary>
        public String Nom { get => nom; set => nom = value; }

        private DateTime date;
        /// <summary>
        /// Lit ou écrit la date de prise
        /// </summary>
        public DateTime Date { get => date; set => date = value; }

        private String comentaire;
        /// <summary>
        /// Lit ou écrit le comentaire
        /// </summary>
        public String Comentaire { get => comentaire; set => comentaire = value; }
    }
}
