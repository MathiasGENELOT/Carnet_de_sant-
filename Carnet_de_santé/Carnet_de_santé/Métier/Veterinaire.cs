using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Carnet_de_santé
{
    [DataContract]
    public class Veterinaire
    {
        [DataMember]
        private string nom;
        /// <summary>
        /// Lit ou écrit le nom
        /// </summary>
        public String Nom { get => nom; set => nom = value; }

        [DataMember]
        private string adresse;
        /// <summary>
        /// Lit ou écrit l'adresse
        /// </summary>
        public string Adresse { get => adresse; set => adresse = value; }

        [DataMember]
        private string telephone;
        /// <summary>
        /// Lit ou écrit le telephone
        /// </summary>
        public string Telephone { get => telephone; set => telephone = value; }

        [DataMember]
        private string mail;
        /// <summary>
        /// Lit ou écrit le mail
        /// </summary>
        public string Mail { get => mail; set => mail = value; }

        public Veterinaire()
        { 
        
        }
    }
}
