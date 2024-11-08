using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sicily.DAL;
using SicilyLines.Modele;


namespace SicilyLines.Controler
{
    public class Mgr
    {

        List<Liaison> maListeLiaison;

        public Mgr()
        {

            maListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des liaisons à partir de la DAL
        public List<Liaison> chargementLiaisonsBD()
        {

            maListeLiaison = SicilyDAO.getLiaisons();

            return (maListeLiaison);
        }


        // Mise à jour d'un employé  dans la DAL
        //public void updateEmploye(Employe e)
        //{

        //    EmployeDAO.updateEmploye(e);

        //}

        //// Suppresion dans la DAL
        //public void deleteEmploye(Employe e)
        //{

        //    EmployeDAO.deleteEmploye(e);

        //}

        //// Insertion dans la DAL
        //public void insertEmploye(int id, string login)
        //{

        //    EmployeDAO.insertEmploye(id, login);

        //}

    }
}
