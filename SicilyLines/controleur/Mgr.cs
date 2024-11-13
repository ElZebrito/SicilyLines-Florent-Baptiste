using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SicilyLines.DAL;
using SicilyLines.Modele;


namespace SicilyLines.Controler
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
