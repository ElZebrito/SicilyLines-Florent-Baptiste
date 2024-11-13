using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Liaison
    {
        private int idLiaison;
        private TimeSpan duree;
        private Secteur idSecteur;
        private Port idPortDepart;
        private Port idPortArrivee;

        public Liaison(int idLiaison, TimeSpan duree, Secteur idSecteur, Port idPortDepart, Port idPortArrivee)
        {
            this.idLiaison = idLiaison;
            this.duree = duree;
            this.idSecteur = idSecteur;
            this.idPortDepart = idPortDepart;
            this.idPortArrivee = idPortArrivee;
        }

        public int IdLiaison
        {
            get => idLiaison;
        }

        public TimeSpan Duree
        {
            get => duree;
        }

        public Secteur IdSecteur
        {
            get => idSecteur;
        }

        public Port IdPortDepart
        {
            get => idPortDepart;
        }

        public Port IdPortArrivee
        {
            get => idPortArrivee;
        }

        public string Description
        {
            get => $"Id Liaison : {idLiaison}, Nom Port Départ : {idPortDepart.Nom}, Nom Port Arrivée : {idPortArrivee.Nom}, Durée : {duree}";
        }
    }
}