using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Traversee
    {
        private int IDTRAVERSEE;
        private Liaison IDLIAISON;
        private Bateau IDBATEAU;
        private DateTime DATETRAVERSEE;
        private string HEURE;

        // remplace getId()
        public int IdTr { get => IDTRAVERSEE; }
        public Liaison IdLi { get => IDLIAISON; }

        public Bateau IdBat { get => IDBATEAU; }
        public DateTime IdDateTr { get => DATETRAVERSEE; }
        public string IdH { get => HEURE; }


        public Traversee(int IdTr, Liaison IdLi, Bateau IdBat, DateTime IdDateTr, String IdH)
        {
            this.IDTRAVERSEE = IdTr;
            this.IDLIAISON = IdLi;
            this.IDBATEAU = IdBat;
            this.DATETRAVERSEE = IdDateTr;
            this.HEURE = IdH;


        }





        public string DescriptionTraversee
        {
            get => "Id Traversee : " + this.IDTRAVERSEE + " IdLiaison : " + this.IDLIAISON + " Numéro Bateau : " + this.IDBATEAU + " Date de la Traversée : " + this.DATETRAVERSEE + " Heure de la traversée : " + this.HEURE;
        }


    }
}
