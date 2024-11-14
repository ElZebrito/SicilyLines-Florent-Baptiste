using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Bateau
    {
        private int idBateau;
        public Bateau(int idBateau)
        {
            this.idBateau = idBateau;
        }
        public int IdBateau
        {
            get => idBateau;
        }
    }
}
