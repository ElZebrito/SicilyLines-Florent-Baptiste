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



        // R�cup�ration de la liste des employ�s � partir de la DAL
        public List<Liaison> chargementLiaisonBD()
        {

            maListeLiaison = LiaisonDAO.getLiaisons();

            return (maListeLiaison);
        }

        // R�cup�ration de la liste des Traversees � partir de la DAL
        public List<Traversee> chargementTraverseeLiaisonBD(Liaison uneLiaison)
        {

            maListeTraversee = TraverseeDAO.getTraverseeLiaisons(uneLiaison);

            return (maListeTraversee);
        }
        public void SupTraversee(Traversee traversee)
        {
            TraverseeDAO.SupTraversee(traversee);

        }

        public void InsererNouvelleTraverseeAutoId(int idBateau, Liaison liaison, string dateTraversee, TimeSpan heure)
        {
            Traversee nouvelleTraversee = new Traversee(0, idBateau, liaison, dateTraversee, heure); // ID temporairement � 0
            TraverseeDAO.InsertTraverseeAutoId(nouvelleTraversee);
        }


        public void updateTraversee(Traversee t)
        {
            TraverseeDAO.updateTraverseeDateHeure(t); 
        }



    }
}