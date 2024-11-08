using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    internal class SecteurDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;

        public static List<Secteur> getSecteurs()
        {
            List<Secteur> ls = new List<Secteur>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select * from secteur");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur s;

                while (reader.Read())
                {
                    int iDSECTEUR = (int)reader.GetValue(0);
                    string lIBELLE = (string)reader.GetValue(1);

                    // Instanciation d'un secteur
                    s = new Secteur(iDSECTEUR, lIBELLE);


                    // Ajout de cette liaison à la liste 
                    ls.Add(s);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return ls;
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }
    }
}
