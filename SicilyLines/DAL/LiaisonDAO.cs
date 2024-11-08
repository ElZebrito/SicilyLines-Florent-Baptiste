using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    internal class LiaisonDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "sicilylines";
        private static string uid = "root";
        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;

        public static List<Liaison> getLiaisons()
        {
            List<Liaison> ll = new List<Liaison>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("Select * from liaison");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Liaison l;

                while (reader.Read())
                {
                    int iDLIAISON = (int)reader.GetValue(0);
                    int iDSECTEUR = (int)reader.GetValue(1);
                    string LIBELLE = (string)reader.GetValue(2);
                    int iDPORTD = (int)reader.GetValue(3);
                    string lIBPORTD = (string)reader.GetValue(4);
                    int iDPORTA = (int)reader.GetValue(5);
                    string lIBPORTA = (string)reader.GetValue(6);
                    string duree = (string)reader.GetValue(7);


                    Secteur s = new Secteur(iDSECTEUR, LIBELLE);
                    Port portd = new Port(iDPORTD, lIBPORTD);
                    Port porta = new Port(iDPORTA, lIBPORTA);
                    // Instanciation d'une Liaison
                    l = new Liaison(iDLIAISON,s, portd, porta, duree);

                    // Ajout de cette liaison à la liste 
                    ll.Add(l);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return ll;
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }
    }
}
