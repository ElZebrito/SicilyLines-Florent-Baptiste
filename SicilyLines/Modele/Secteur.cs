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
        public int IdSecteur { get; set; }
        public string Libelle { get; set; }

        public Secteur(int idSecteur, string libelle)
        {
            IdSecteur = idSecteur;
            Libelle = libelle;
        }
    }

}
