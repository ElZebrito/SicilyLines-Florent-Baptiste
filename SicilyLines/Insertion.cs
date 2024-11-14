using SicilyLines.Controler;
using SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SicilyLines
{
    public partial class Insertion : Form
    {
        private Traversee t; // La traversée en cours de modification (null si on ajoute)
        private Mgr monManager;
        private List<Liaison> lstLiaison = new List<Liaison>();
        private List<Traversee> lstTraversee = new List<Traversee>();
        private List<Bateau> lstBateau = new List<Bateau>();
        private Liaison liaison;
        private Traversee traversee;

        public Insertion(Liaison liaison, Traversee traversee)
        {
            InitializeComponent();
            monManager = new Mgr();

            this.liaison = liaison;
            this.traversee = traversee;
        }

        private void Insertion_Load(object sender, EventArgs e)
        {
            if (t != null)
            {
                confirmButton.Text = "Valider la modification";
                tbIdTraversee.Text = t.IdTraversee.ToString();
                cbIdBateau.SelectedItem = t.IdBateau;
                tbDateTraversee.Text = t.DateTraversee;
                tbHeure.Text = t.Heure.ToString(@"hh\:mm\:ss");
            }
            else
            {
                // Initialisation pour l'ajout
                SetPlaceholder(tbDateTraversee, "YYYY-MM-DD");
                SetPlaceholder(tbHeure, "HH:MM:SS");

                // Charger les bateaux depuis la base de données
                lstBateau = monManager.chargementBateauBD();

                // Remplir le ComboBox des bateaux
                foreach (Bateau bateau in lstBateau)
                {
                    cbIdBateau.Items.Add(bateau.IdBateau);
                }

                // Text du bouton
                confirmButton.Text = "Valider l'insertion";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (selectedLiaison == null)
            {
                MessageBox.Show("Aucune liaison sélectionnée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (t != null)
                {
                    monManager.updateTraversee(t);
                }
                else
                {
                    // Récupérer les valeurs saisies
                    int idTraversee = int.Parse(tbIdTraversee.Text);
                    int idBateau = Convert.ToInt32(cbIdBateau.SelectedItem);
                    string dateTraversee = tbDateTraversee.Text;
                    TimeSpan heure = TimeSpan.Parse(tbHeure.Text);

                    // Insérer la nouvelle traversée dans la base de données
                    monManager.InsererNouvelleTraversee(idTraversee, idBateau, selectedLiaison, dateTraversee, heure);
                }
                    // Message de confirmation
                    MessageBox.Show("Traversée ajoutée avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Fermer le formulaire après l'insertion
                    this.Close();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Veuillez vérifier les informations saisies.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
    }
}
