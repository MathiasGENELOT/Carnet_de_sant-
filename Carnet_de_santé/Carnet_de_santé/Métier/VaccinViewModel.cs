using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Carnet_de_santé
{
    public class VaccinViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Vaccin model;
        /// <summary>
        /// Obtient le modèle
        /// </summary>
        public Vaccin Model { get => model; }

        /// <summary>
        /// Initialise le contrôleur
        /// </summary>
        /// <param name="m">le modèle</param>
        public VaccinViewModel(Vaccin v) 
        {
            model = v;
        }

        /// <summary>
        /// Lit ou écrit le Nom
        /// </summary>
        public string Nom
        {
            get => model.Nom;
            set
            {
                model.Nom = value;
                OnChange("Nom");
            }
        }

        /// <summary>
        /// Lit ou écrit la date
        /// </summary>
        public DateTime Date
        {
            get => model.Date;
            set
            {
                model.Date = value;
                OnChange("Date");
            }
        }

        /// <summary>
        /// Lit ou écrit la le comentaire
        /// </summary>
       
        public string Comentaire
        {
            get => model.Comentaire;
            set
            {
                model.Comentaire = value;
                OnChange("Comentaire");
            }
        }
    }
}
