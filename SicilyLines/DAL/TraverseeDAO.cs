using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    internal class TraverseeDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;

        public static List<Traversee> getTraversees()
        {
            List<Traversee> lt = new List<Traversee>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select * from Traversee");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Traversee t;

                while (reader.Read())
                {
                    int iDLIAISON = (int)reader.GetValue(0);
                    int iDTRAVERSEE = (int)reader.GetValue(1);
                    int iDBATEAU = (int)reader.GetValue(2);
                    string dATETRAVERSEE = (string)reader.GetValue(3);
                    string hEURE = (string)reader.GetValue(4);

                    // Instanciation d'une Liaison
                    t = new Traversee(iDLIAISON, iDTRAVERSEE, iDBATEAU, dATETRAVERSEE, hEURE);

                    // Ajout de cette liaison à la liste 
                    lt.Add(t);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return lt;
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }
    }
}
