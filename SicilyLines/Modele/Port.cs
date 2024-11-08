using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Port
    {
        public int IdPort { get; set; }
        public string Nom { get; set; }

        public Port(int idPort, string nom)
        {
            IdPort = idPort;
            Nom = nom;
        }
    }

}
