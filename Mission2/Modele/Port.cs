using System;

namespace Mission2.Modele
{
    public class Port
    {
        private int idPort;
        private string nom;

        public Port(int idPort, string nom)
        {
            this.idPort = idPort;
            this.nom = nom;
        }

        public int IdPort
        {
            get => idPort;
        }

        public string Nom
        {
            get => nom;
        }
        public string Description
        {
            get => $"Nom du Port : {nom} (ID : {idPort})"; // Format de description
        }
    }
}
