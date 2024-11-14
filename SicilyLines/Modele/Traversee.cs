using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines.Modele
{
    public class Traversee
    {
        private int idTraversee;
        private int idBateau;
        private Liaison liaison;
        private string dateTraversee;
        private TimeSpan heure;

        public Traversee(int idTraversee, int idBateau, Liaison liaison, string dateTraversee, TimeSpan heure)
        {
            this.idTraversee = idTraversee;
            this.idBateau = idBateau;
            this.liaison = liaison;
            this.dateTraversee = dateTraversee;
            this.heure = heure;
        }

        public int IdTraversee
        {
            get => idTraversee;
        }

        public int IdBateau
        {
            get => idBateau;
        }

        public Liaison Liaison
        {
            get => liaison;
        }

        public string DateTraversee
        {
            get => dateTraversee;
        }

        public TimeSpan Heure
        {
            get => heure;
        }
        public string Description
        {
            get => $"Id Traversee : {idTraversee}, IdBateau : {IdBateau}, Id Liaison : {liaison.IdLiaison}, Date traversée : {dateTraversee}, Heure : {heure}";
        }
    }
}
