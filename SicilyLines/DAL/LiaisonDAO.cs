using MySql.Data.MySqlClient;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.DAL
{
    public class LiaisonDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des liaisons
        public static List<Liaison> getLiaisons()
        {
            List<Liaison> ll = new List<Liaison>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT l.IDLIAISON, s.IDSECTEUR, s.LIBELLE, p1.IDPORT AS IDPORTDEPART, p1.NOM AS LIBPORTDEPART, p2.IDPORT AS IDPORTARRIVEE, p2.NOM AS LIBPORTARRIVEE, l.DUREE FROM Liaison l INNER JOIN Secteur s ON l.IDSECTEUR = s.IDSECTEUR INNER JOIN Port p1 ON l.IDPORTDEPART = p1.IDPORT INNER JOIN Port p2 ON l.IDPORTARRIVEE = p2.IDPORT;");

                MySqlDataReader reader = Ocom.ExecuteReader();

                while (reader.Read())
                {
                    int idLiaison = (int)reader.GetValue(0);
                    int idSecteur = (int)reader.GetValue(1);
                    string libSecteur = (string)reader.GetValue(2); // Correction ici
                    int idPortD = (int)reader.GetValue(3);
                    string libPortD = (string)reader.GetValue(4);
                    int idPortA = (int)reader.GetValue(5);
                    string libPortA = (string)reader.GetValue(6);
                    TimeSpan duree = (TimeSpan)reader.GetValue(7);

                    Secteur s = new Secteur(idSecteur, libSecteur);
                    Port portD = new Port(idPortD, libPortD);
                    Port portA = new Port(idPortA, libPortA);

                    // Instanciation d'une liaison
                    Liaison l = new Liaison(idLiaison, duree, s, portD, portA);

                    // Ajout de cette Liaison à la liste 
                    ll.Add(l);
                }

                reader.Close();
                maConnexionSql.closeConnection();

                return ll;
            }
            catch (Exception emp)
            {
                throw emp;
            }
        }

    }
}
