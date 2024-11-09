using Mission2.DAL;
using Mission2.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.Controleur
{
    internal class Mgr
    {
        LiaisonDAO LiaisonDAO = new LiaisonDAO();

        List<Liaison> maListeLiaison;

        public Mgr()
        {

            maListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des employés à partir de la DAL
        public List<Liaison> chargementLiaisonBD()
        {

            maListeLiaison = LiaisonDAO.getLiaisons();

            return (maListeLiaison);
        }
    }
}
