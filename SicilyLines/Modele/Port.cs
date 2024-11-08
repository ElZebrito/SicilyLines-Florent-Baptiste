using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Port
    {
        private int IDPORT;
        private string NOM;

        // constructeurs 
        public Port()
        {
        }

        public int IdPort { get => IDPORT; }
        public string Nom { get => NOM; }

        public Port(int IdP, string Nom)
        {
            IDPORT = IdP;
            NOM = Nom;
        }

    }
}
