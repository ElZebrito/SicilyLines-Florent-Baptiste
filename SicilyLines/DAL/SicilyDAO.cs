using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System.Security.Principal;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;

namespace Sicily.DAL
{
    public class SicilyDAO
    {

       /* // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;
        private static MySqlCommand Ocom2;
        private static MySqlCommand Ocom3;




        // Récupération de la liste des Secteur
        public static List<Secteur> getSecteurs()
        {

            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur s;




                while (reader.Read())
                {

                    int ID_SECTEUR = (int)reader.GetValue(0);
                    string LIBELLE_SECTEUR = (string)reader.GetValue(1);


                    //Instanciation d'un Secteur
                    s = new Secteur(ID_SECTEUR, LIBELLE_SECTEUR);

                    // Ajout de ce secteur à la liste 
                    lc.Add(s);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static List<Liaison> getLiaisons()
        {

            List<Liaison> ll = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom2 = maConnexionSql.reqExec("Select * from liaison");


                MySqlDataReader reader = Ocom2.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int ID_LIAISON = (int)reader.GetValue(0);
                    int ID_SECTEUR = (int)reader.GetValue(1);
                    int ID_PORT = (int)reader.GetValue(2);
                    int ID_PORT_ARRIVEE = (int)reader.GetValue(3);
                    //string DUREE_LIAISON = (string)reader.GetValue(4);
                    TimeSpan DUREE_LIAISON = reader.GetTimeSpan(4);

                    //Instanciation d'un Secteur
                    l = new Liaison(ID_LIAISON, ID_SECTEUR, ID_PORT, ID_PORT_ARRIVEE, DUREE_LIAISON);

                    // Ajout de ce secteur à la liste 
                    ll.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (ll);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static List<Liaison> TrouverLiaison(Secteur s, List<Liaison> ll)
        {

            List<Liaison> ListeLiaisonSecteur = new List<Liaison>();

            foreach (Liaison liaison in ll)
            {
                if (liaison.IdSecteur == s.Id)
                {
                    ListeLiaisonSecteur.Add(liaison);
                }
            }

            return ListeLiaisonSecteur;

        }


        public static List<Traversee> TrouverTraversee(Liaison l, List<Traversee> lTR)
        {

            List<Traversee> ListeLiaisonTraversee = new List<Traversee>();

            foreach (Traversee traversee in lTR)
            {
                if (l.IdLiaison == traversee.IdLi)
                {
                    ListeLiaisonTraversee.Add(traversee);
                }



            }

            return ListeLiaisonTraversee;

        }

        public static void SupLiaison(Liaison liaison)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                // Supprimer d'abord les entrées liées dans traversee
                string deleteTraverseeQuery = "DELETE FROM traversee WHERE ID_LIAISON = " + liaison.IdLiaison;
                MySqlCommand deleteTraverseeCommand = maConnexionSql.reqExec(deleteTraverseeQuery);
                deleteTraverseeCommand.ExecuteNonQuery();

                // Ensuite, supprimer la liaison dans la table principale
                string deleteLiaisonQuery = "DELETE FROM liaison WHERE ID_LIAISON = " + liaison.IdLiaison;
                MySqlCommand deleteLiaisonCommand = maConnexionSql.reqExec(deleteLiaisonQuery);
                deleteLiaisonCommand.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }


        public static void ModifDurer(Liaison liaison, string Duree_LIAISON)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                string query = $"UPDATE liaison SET DUREE_LIAISON = '{Duree_LIAISON}' WHERE ID_LIAISON = {liaison.IdLiaison}";

                Console.WriteLine("Query: " + query); // Ajoutez cette ligne pour afficher la requête SQL

                Ocom = maConnexionSql.reqExec(query);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }


        public static void InsertLiaison(Liaison liaison)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                string query = "INSERT INTO liaison (ID_LIAISON, ID_SECTEUR, ID_PORT, ID_PORT_ARRIVEE, DUREE_LIAISON) " +
                               $"VALUES ({liaison.IdLiaison}, {liaison.IdSecteur}, {liaison.IdPortDepart}, {liaison.IdPortArrivee}, '{liaison.Duree}')";

                Ocom = maConnexionSql.reqExec(query);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }


        public static List<Traversee> getTraversee()
        {

            List<Traversee> lTR = new List<Traversee>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from traversee");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Traversee T;


                while (reader.Read())
                {

                    int ID_TRAVERSEE = (int)reader.GetValue(0);
                    int ID_LIAISON = (int)reader.GetValue(1);
                    int ID_BATEAU = (int)reader.GetValue(1);

                    //Instanciation d'une Traversee
                    T = new Traversee(ID_TRAVERSEE, ID_LIAISON, ID_BATEAU);

                    // Ajout de ce secteur à la liste 
                    lTR.Add(T);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lTR);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }*/
    }




}