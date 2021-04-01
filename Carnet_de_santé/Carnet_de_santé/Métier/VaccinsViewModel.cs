using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Carnet_de_santé
{
    /// <summary>
    /// Contrôleur pour Notes
    /// </summary>
    public class VaccinsViewModel
    {
        private ListeVaccins model;

        private ObservableCollection<VaccinViewModel> list = new ObservableCollection<VaccinViewModel>();
        /// <summary>
        /// Obtient la collection observable des notes
        /// </summary>
        public ObservableCollection<VaccinViewModel> List { get => list; }

        /// <summary>
        /// Initialise le contrôleur
        /// </summary>
        /// <param name="notes">le modèle</param>
        public VaccinsViewModel(ListeVaccins vaccins)
        {
            model = vaccins;
            foreach (Vaccin v in model.getListVaccins())
                list.Add(new VaccinViewModel(v));
        }

        /// <summary>
        /// Ajoute une note
        /// </summary>
        /// <param name="n">la note à ajouter</param>
        /// <returns>Le contrôleur créé pour la note</returns>
        public VaccinViewModel Add(Vaccin v)
        {
            model.add(v);
            VaccinViewModel vvm = new VaccinViewModel(v);
            list.Add(vvm);
            return vvm;
        }
    }
}
