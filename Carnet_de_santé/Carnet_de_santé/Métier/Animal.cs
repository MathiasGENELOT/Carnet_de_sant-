using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Runtime.Serialization;

namespace Carnet_de_santé
{

    [DataContract]
    public class Animal
    {
        [DataMember]
        private string nom;
        /// <summary>
        /// Lit ou écrit le Nom
        /// </summary>
        public String Nom { get => nom; set => nom = value; }

        [DataMember]
        private String image;
        /// <summary>
        /// Lit ou écrit l'Image
        /// </summary>
        public String Image { get => image; set => image = value; }

        [DataMember]
        private DateTime date;
        /// <summary>
        /// Lit ou écrit la Date
        /// </summary>
        public DateTime Date { get => date; set => date = value; }

        [DataMember]
        private string espece;
        /// <summary>
        /// Lit ou écrit le Espece
        /// </summary>
        public string Espece { get => espece; set => espece = value; }

        [DataMember]
        private string race;
        /// <summary>
        /// Lit ou écrit la Race
        /// </summary>
        public string Race { get => race; set => race = value; }
        
        [DataMember]
        private string sexe;
        /// <summary>
        /// Lit ou écrit le Sexe
        /// </summary>
        public string Sexe { get => sexe; set => sexe = value; }
        
        [DataMember]
        private string numeroID;
        /// <summary>
        /// Lit ou écrit le numeroId
        /// </summary>
        public string NumeroID { get => numeroID; set => numeroID = value; }

        public Animal()
        {}

         
    }
}
