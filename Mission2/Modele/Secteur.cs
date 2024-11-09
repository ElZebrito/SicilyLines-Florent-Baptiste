using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.Modele
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
