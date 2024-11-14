using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    public class BateauDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des bateaux
        public static List<Bateau> getBateaux()
        {
            List<Bateau> lb = new List<Bateau>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT IDBATEAU FROM bateau;");

                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    int idBateau = (int)reader.GetValue(0);

                    // Instanciation d'un bateau
                    Bateau b = new Bateau(idBateau);

                    // Ajout du bateau à la liste 
                    lb.Add(b);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                return lb;
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }

    }
}
