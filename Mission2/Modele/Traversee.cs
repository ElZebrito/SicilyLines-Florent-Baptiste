using System;

namespace Mission2.Modele
{
    public class Traversee
    {
        private string idTraversee;
        private string idBateau;
        private Liaison liaison;
        private DateTime dateTraversee;
        private TimeSpan heure;

        public Traversee(string idTraversee, string idBateau, Liaison liaison, DateTime dateTraversee, TimeSpan heure)
        {
            this.idTraversee = idTraversee;
            this.idBateau = idBateau;
            this.liaison = liaison;
            this.dateTraversee = dateTraversee;
            this.heure = heure;
        }

        public string IdTraversee
        {
            get => idTraversee;
        }

        public string IdBateau
        {
            get => idBateau;
        }

        public Liaison Liaison
        {
            get => liaison;
        }

        public DateTime DateTraversee
        {
            get => dateTraversee;
        }

        public TimeSpan Heure
        {
            get => heure;
        }
    }
}
