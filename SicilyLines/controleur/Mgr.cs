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
        List<Bateau> maListeBateau;

        public Mgr()
        {

            maListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des liaisons à partir de la DAL
        public List<Liaison> chargementLiaisonBD()
        {

            maListeLiaison = LiaisonDAO.getLiaisons();

            return (maListeLiaison);
        }

        // Récupération de la liste des bateaux à partir de la DAL
        public List<Bateau> chargementBateauBD()
        {

            maListeBateau = BateauDAO.getBateaux();

            return (maListeBateau);
        }

        // Récupération de la liste des Traversees à partir de la DAL
        public List<Traversee> chargementTraverseeLiaisonBD(Liaison uneLiaison)
        {

            maListeTraversee = TraverseeDAO.getTraverseeLiaisons(uneLiaison);

            return (maListeTraversee);
        }

        // Insertion Traversée
        public void InsererNouvelleTraversee(int idTraversee, int idBateau, Liaison liaison, string dateTraversee, TimeSpan heure)
        {
            Traversee nouvelleTraversee = new Traversee(idTraversee, idBateau, liaison, dateTraversee, heure);
            TraverseeDAO.InsertTraversee(nouvelleTraversee);
        }

        // Update Traversée
        public void updateTraversee(Traversee t)
        {

            TraverseeDAO.updateTraversee(t);

        }


    }
}