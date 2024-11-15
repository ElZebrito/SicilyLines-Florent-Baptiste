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

                    Traversee t = new Traversee(idTraversee, idBateau, uneLiaison, dateTraversee, heure);

                    lt.Add(t);
                }


                reader.Close();
                maConnexionSql.closeConnection();
                return lt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Traversee> TrouverTraversee(Liaison l, List<Traversee> lt)
        {

            List<Traversee> ListeTraverseeLiaison = new List<Traversee>();

            foreach (Traversee traversee in lt)
            {
                if (traversee.Liaison == l)
                {
                    ListeTraverseeLiaison.Add(traversee);
                }
            }

            return ListeTraverseeLiaison;

        }

        public static void SupTraversee(Traversee traversee)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();


                string query = $"DELETE FROM traversee WHERE IDTRAVERSEE = {traversee.IdTraversee}";

                Ocom = maConnexionSql.reqExec(query);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la suppression de la traversée : " + ex.Message);
            }
        }



        //INSERTION
        public static int GetNextIdTraversee()
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                string query = "SELECT MAX(IDTRAVERSEE) FROM traversee";
                Ocom = maConnexionSql.reqExec(query);
                object result = Ocom.ExecuteScalar();
                maConnexionSql.closeConnection();

                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result) + 1;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la récupération du prochain ID de traversée : " + ex.Message);
            }
        }
        public static void InsertTraverseeAutoId(Traversee traversee)
        {
            try
            {
                int nextId = GetNextIdTraversee();

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                string query = "INSERT INTO traversee (IDTRAVERSEE, IDBATEAU, IDLIAISON, DATETRAVERSEE, HEURE) " +
                               $"VALUES ({nextId}, {traversee.IdBateau}, {traversee.Liaison.IdLiaison}, '{traversee.DateTraversee}', '{traversee.Heure}')";

                Ocom = maConnexionSql.reqExec(query);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception ex)
            {
                maConnexionSql.closeConnection();
                throw new Exception("Erreur lors de l'insertion de la traversée avec ID automatique : " + ex.Message);
            }
        }


        public static void updateTraverseeDateHeure(Traversee t)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                // Mise à jour de la date et de l'heure uniquement
                string query = $"UPDATE traversee " +
                               $"SET DATETRAVERSEE = '{t.DateTraversee}', HEURE = '{t.Heure}' " +
                               $"WHERE IDTRAVERSEE = {t.IdTraversee}";

                Ocom = maConnexionSql.reqExec(query);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de la mise à jour de la traversée : " + ex.Message);
            }
        }



    }
}