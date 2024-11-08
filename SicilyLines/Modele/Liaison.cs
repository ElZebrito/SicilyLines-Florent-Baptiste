using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Liaison
    {
        private int IDLIAISON;
        private Secteur IDSECTEUR;
        private Port IDPORTDEPART;
        private Port IDPORTARRIVEE;
        private string DUREELIAISON;
        






        // remplace getId()
        public int IdLiaison { get => IDLIAISON; }
        public Secteur Secteur;
        public Port PortDepart;
        public Port PortArrivee;
        public string Duree { get => DUREELIAISON;}
        

        public Liaison(int idLiaison, Secteur idSecteur, Port portDepart, Port portArrivee, String duree)
        {
            IDLIAISON = idLiaison;
            IDSECTEUR = idSecteur;
            IDPORTARRIVEE = portDepart;
            IDPORTDEPART = portArrivee;
            DUREELIAISON = duree;
           
        }



        // Constructeur vide


   
        public string DescriptionLIAISON
        {
            get => "IdL : " + this.IDLIAISON + " IdS : " + this.IDSECTEUR + " IdPortDepart : " + this.IDPORTDEPART + " IdPortArrivee : " + this.IDPORTARRIVEE + " Duree : " + this.DUREELIAISON;
        }

    }
}