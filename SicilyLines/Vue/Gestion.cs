using SicilyLines.Controler;
using SicilyLines.DAL;
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
        List<Traversee> ListeTraverseeParLiaison;
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
            try
            {
                lstLiaison = monManager.chargementLiaisonBD();
                afficherLiaison();

                // Mettre à jour l'ID de traversée au chargement
                MettreAJourIdTraversee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }


        private void lbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liaison uneLiaison = (Liaison)lbLiaison.SelectedItem;
            lstTraversee = monManager.chargementTraverseeLiaisonBD(uneLiaison);
            afficherTraversee();
        }


        private void MettreAJourIdTraversee()
        {
            try
            {
                int prochainId = TraverseeDAO.GetNextIdTraversee();

                tbIdTraversee.Text = prochainId.ToString();
                tbIdTraversee.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération du prochain ID de traversée : " + ex.Message);
            }
        }





        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int idBateau = Convert.ToInt32(tbIdBateau.Text);
                Liaison selectedLiaison = (Liaison)lbLiaison.SelectedItem;
                string dateTraversee = tbDateTraversee.Text;
                TimeSpan heure = TimeSpan.Parse(tbHeure.Text);

                // Appel de la méthode sans ID
                monManager.InsererNouvelleTraverseeAutoId(idBateau, selectedLiaison, dateTraversee, heure);

                // Rafraîchir la liste des traversées
                lstTraversee = monManager.chargementTraverseeLiaisonBD(selectedLiaison);
                afficherTraversee();

                // Vider les champs de saisie
                tbIdBateau.Clear();
                tbDateTraversee.Clear();
                tbHeure.Clear();

                // Actualiser l'ID de traversée automatiquement
                MettreAJourIdTraversee();

                MessageBox.Show("Traversée ajoutée avec succès.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la traversée : " + ex.Message);
            }
        }




        private void deleteButton_Click(object sender, EventArgs e)
        {
            Traversee traversee = lbTraversee.SelectedItem as Traversee;

            if (traversee != null)
            {
                try
                {
                    monManager.SupTraversee(traversee);

                    Liaison selectedLiaison = lbLiaison.SelectedItem as Liaison;
                    lstTraversee = monManager.chargementTraverseeLiaisonBD(selectedLiaison);
                    afficherTraversee();

                    MessageBox.Show("Traversée supprimée avec succès.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression de la traversée : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une traversée à supprimer.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (lbLiaison.SelectedItem != null)
            {
                Liaison selectedLiaison = (Liaison)lbLiaison.SelectedItem;

                if (lbTraversee.SelectedItem != null)
                {
                    Traversee selectedTraversee = (Traversee)lbTraversee.SelectedItem;

                    // Ouvre le formulaire de modification
                    Update updateForm = new Update(selectedTraversee);
                    updateForm.ShowDialog();

                    // Recharge la liste après modification
                    lstTraversee = monManager.chargementTraverseeLiaisonBD(selectedLiaison);
                    afficherTraversee();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une traversée à modifier.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une liaison.");
            }
        }

    }
}