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
    public partial class Update : Form
    {
        private Traversee t;
        private Mgr monManager;
        private Liaison selectedLiaison;
        private Traversee selectedTraversee;
        public Update(Traversee selectedTraversee, Liaison selectedLiaison)
        {
            InitializeComponent();
            monManager = new Mgr();
            this.selectedTraversee = selectedTraversee;
            this.selectedLiaison = selectedLiaison;
            t = selectedTraversee;
        }


        private void Update_Load(object sender, EventArgs e)
        {
            tbTraversee.Text = t.IdTraversee.ToString();
            tbBateau.Text = t.IdBateau.ToString();
            tbDate.Text = t.DateTraversee;
            tbHeure.Text = t.Heure.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Appeler la méthode de mise à jour avec l'objet modifié
                monManager.updateTraversee(t);

                // Message de confirmation
                MessageBox.Show("Traversée modifiée avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermer le formulaire après la mise à jour
                this.Close();
            }
            catch (Exception ex)
            {
                // Afficher un message d'erreur si la mise à jour échoue
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
