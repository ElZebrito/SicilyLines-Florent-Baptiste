using MySqlX.XDevAPI.Relational;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SicilyLines.Modele
{
    public class Secteur
    {
        private int IDSECTEUR;
        private string LIBELLE;

        // constructeurs 
        public Secteur()
        {
        }

        public int IdSecteur { get => IDSECTEUR; }
        public string Libelle { get => LIBELLE; }


        public Secteur(int IdS , string Lib)
        {
            IDSECTEUR = IdS;
            LIBELLE = Lib;
        }

        /*public override String ToString()
        {
            return "Secteur " + this.IDSECTEUR + ", " + this.LIBELLE;
        }*/
    }
}
