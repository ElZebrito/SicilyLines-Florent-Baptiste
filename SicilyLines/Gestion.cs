using SicilyLines.Controler;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicilyLines
{
    public partial class Gestion : Form
    {
        Mgr monManager;
        List<Liaison> lstLiaison = new List<Liaison>();
        List<Traversee> lstTraversee = new List<Traversee>();
        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        public void afficherLiaison()
        {
            try
            {
                lbLiaison.DataSource = null;
                lbLiaison.DataSource = lstLiaison;
                lbLiaison.DisplayMember = "Description";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void afficherTraversee()
        {
            try
            {
                lbTraversee.DataSource = null;
                lbTraversee.DataSource = lstTraversee;
                lbTraversee.DisplayMember = "Description";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            lstLiaison = monManager.chargementLiaisonBD();
            afficherLiaison();
        }

        private void lbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liaison uneLiaison = (Liaison)lbLiaison.SelectedItem;
            lstTraversee = monManager.chargementTraverseeLiaisonBD(uneLiaison);
            afficherTraversee();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idTraversee = Convert.ToInt32(tbIdTraversee.Text);
                int idBateau = Convert.ToInt32(tbIdBateau.Text);
                Liaison selectedLiaison = (Liaison)lbLiaison.SelectedItem;
                string dateTraversee = tbDateTraversee.Text;
                TimeSpan heure = TimeSpan.Parse(tbHeure.Text);

                monManager.InsererNouvelleTraversee(idTraversee, idBateau, selectedLiaison, dateTraversee, heure);

                // Rafraîchir la liste des traversées
                lstTraversee = monManager.chargementTraverseeLiaisonBD(selectedLiaison);
                afficherTraversee();

                MessageBox.Show("Traversée ajoutée avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la traversée : " + ex.Message);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbIdBateau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}