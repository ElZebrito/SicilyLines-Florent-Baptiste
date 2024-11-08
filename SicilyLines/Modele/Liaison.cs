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
        public Secteur IdSecteur { get => IDSECTEUR; }
        public Port IdPortDepart { get => IDPORTDEPART; }
        public Port IdPortArrivee { get => IDPORTARRIVEE; }
        public string Duree { get => DUREELIAISON;}
        

        public Liaison(int iDLIAISON, Secteur iDSECTEUR, Port iDPORTDEPART, Port iDPORTARRIVEE, String dUREELIAISON)
        {
            IDLIAISON = iDLIAISON;
            IDSECTEUR = iDSECTEUR;
            IDPORTDEPART = iDPORTDEPART;
            IDPORTARRIVEE = iDPORTARRIVEE;
            DUREELIAISON = dUREELIAISON;
           
        }



        // Constructeur vide


   
        public string DescriptionLIAISON
        {
            get => "IdL : " + this.IDLIAISON + " IdS : " + this.IDSECTEUR + " IdPortDepart : " + this.IDPORTDEPART + " IdPortArrivee : " + this.IDPORTARRIVEE + " Duree : " + this.DUREELIAISON;
        }

    }
}