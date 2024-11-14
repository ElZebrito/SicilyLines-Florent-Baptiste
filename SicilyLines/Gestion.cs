﻿using SicilyLines.Controler;
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

        //private void insertButton_Click(object sender, EventArgs e)
        //{
        //    Liaison selectedLiaison = (Liaison)lbLiaison.SelectedItem;
        //    Insertion insertion = new Insertion(selectedLiaison);
        //    insertion.ShowDialog();
        //    lstTraversee = monManager.chargementTraverseeLiaisonBD(selectedLiaison);
        //    afficherTraversee();
        //}

        //private void updateButton_Click(object sender, EventArgs e)
        //{
        //    // Vérifier si une liaison est sélectionnée
        //    if (lbLiaison.SelectedItem != null)
        //    {
        //        Liaison selectedLiaison = (Liaison)lbLiaison.SelectedItem;

        //        // Charger les traversées associées à la liaison sélectionnée
        //        List<Traversee> traverses = monManager.chargementTraverseeLiaisonBD(selectedLiaison);

        //        // Vérifier si une traversée est sélectionnée dans la liste des traversées (assurez-vous que vous utilisez un ListBox)
        //        if (lstTraversee.SelectedItem != null)
        //        {
        //            Traversee selectedTraversee = (Traversee)lstTraversee.SelectedItem;

        //            // Créer la fenêtre de modification avec la traversée sélectionnée
        //            Insertion insertion = new Insertion(selectedLiaison, selectedTraversee);
        //            insertion.ShowDialog();

        //            // Une fois que la modification est effectuée, rechargez les traversées
        //            lstTraversee = monManager.chargementTraverseeLiaisonBD(selectedLiaison);

        //            // Rafraîchir l'affichage des traversées
        //            afficherTraversee();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Veuillez sélectionner une traversée à modifier.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Veuillez sélectionner une liaison.");
        //    }
        }

    }
