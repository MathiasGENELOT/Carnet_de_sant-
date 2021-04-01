using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Carnet_de_santé
{
    [DataContract]
    public class ListeVaccins
    {
        [DataMember]
        private List<Vaccin> vaccins = new List<Vaccin>();

        public void add(Vaccin v) 
        {
            vaccins.Add(v);
        }

        public void remove(Vaccin v)
        {
            vaccins.Remove(v);
        }

        public List<Vaccin> getListVaccins()
        {
            return vaccins;
        }

    }
}
