using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Bateau
    {
        private int IDBATEAU;
        private string NOM;
        private float LONGUEUR;
        private float LARGEUR;
        private int VITESSE;

        // constructeurs 
        public Bateau()
        {
        }

        public int IdBateau { get => IDBATEAU; }
        public string Nom { get => NOM; }
        public float Longueur { get => LONGUEUR; }
        public float Largeur { get => LARGEUR; }
        public int Vitesse { get => VITESSE; }

        public Bateau(int IdB, string Nom, float Long, float Larg, int Vit)
        {
            IDBATEAU = IdB;
            NOM = Nom;
            LONGUEUR = Long;
            LARGEUR = Larg;
            VITESSE = Vit;
        }
    }
}
