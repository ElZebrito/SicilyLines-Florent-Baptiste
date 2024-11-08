using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    internal class PortDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;

        public static List<Port> getPorts()
        {
            List<Port> lp = new List<Port>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select * from Port");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Port p;

                while (reader.Read())
                {
                    int iDPORT = (int)reader.GetValue(0);
                    string nOM = (string)reader.GetValue(1);

                    // Instanciation d'une Liaison
                    p = new Port(iDPORT, nOM);

                    // Ajout de cette liaison à la liste 
                    lp.Add(p);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return lp;
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }
    }
}
