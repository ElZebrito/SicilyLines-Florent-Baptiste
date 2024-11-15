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

        public Update(Traversee selectedTraversee)
        {
            InitializeComponent();
            monManager = new Mgr();
            t = selectedTraversee;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            // Pré-remplit les champs avec les valeurs actuelles
            tbTraversee.Text = t.IdTraversee.ToString();
            tbTraversee.Enabled = false; 

            tbBateau.Text = t.IdBateau.ToString();
            tbBateau.Enabled = false; 

            tbDate.Text = t.DateTraversee; 
            tbHeure.Text = t.Heure.ToString(@"hh\:mm\:ss"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Met à jour les champs date et heure uniquement
                t.DateTraversee = tbDate.Text;
                t.Heure = TimeSpan.Parse(tbHeure.Text);

                monManager.updateTraversee(t);

                MessageBox.Show("Traversée modifiée avec succès.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la mise à jour : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
