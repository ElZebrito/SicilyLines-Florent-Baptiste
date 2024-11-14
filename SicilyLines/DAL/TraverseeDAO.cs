using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    public class TraverseeDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;
        private static MySqlCommand Ocom;

        public static List<Traversee> getTraverseeLiaisons(Liaison uneLiaison)
        {
            List<Traversee> lt = new List<Traversee>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                string req = "SELECT * FROM traversee WHERE IDLIAISON = '" + uneLiaison.IdLiaison + "'";
                Ocom = maConnexionSql.reqExec(req);
                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    int idTraversee = (int)reader.GetValue(1);
                    int idBateau = (int)reader.GetValue(2);
                    string dateTraversee = (string)reader.GetValue(3);
                    TimeSpan heure = (TimeSpan)reader.GetValue(4);

                    // Instanciation d'une Traversee avec l'objet Liaison passé en paramètre
                    Traversee t = new Traversee(idTraversee, idBateau, uneLiaison, dateTraversee, heure);

                    // Ajout de cette Traversee à la liste 
                    lt.Add(t);
                }


                reader.Close();
                maConnexionSql.closeConnection();
                // Envoi de la liste au Manager
                return lt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InsertTraversee(Traversee traversee)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                string query = "INSERT INTO traversee (IDTRAVERSEE, IDBATEAU, IDLIAISON, DATETRAVERSEE, HEURE) " +
                               $"VALUES ({traversee.IdTraversee}, {traversee.IdBateau}, {traversee.Liaison.IdLiaison}, '{traversee.DateTraversee}', '{traversee.Heure}')";

                Ocom = maConnexionSql.reqExec(query);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l'insertion de la traversée : " + ex.Message);
            }
        }

    }
}