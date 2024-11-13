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
        private int idSecteur;
        private string libSecteur;

        public Secteur(int idSecteur, string libSecteur)
        {
            this.idSecteur = idSecteur;
            this.libSecteur = libSecteur;
        }
        public int IdSecteur
        {
            get => idSecteur;
        }

        public string Description
        {
            get => $"{libSecteur} (ID: {idSecteur})"; // Format de description
        }
    }

}
