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
        List<Traversee> maListeTraversee;

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

        // Récupération de la liste des Traversees à partir de la DAL
        public List<Traversee> chargementTraverseeLiaisonBD(Liaison uneLiaison)
        {

            maListeTraversee = TraverseeDAO.getTraverseeLiaisons(uneLiaison);

            return (maListeTraversee);
        }

        public void InsererNouvelleTraversee(int idTraversee, int idBateau, Liaison liaison, string dateTraversee, TimeSpan heure)
        {
            Traversee nouvelleTraversee = new Traversee(idTraversee, idBateau, liaison, dateTraversee, heure);
            TraverseeDAO.InsertTraversee(nouvelleTraversee);
        }


    }
}