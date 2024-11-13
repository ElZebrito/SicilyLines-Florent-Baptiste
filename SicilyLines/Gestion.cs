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

        private void Gestion_Load(object sender, EventArgs e)
        {
            lstLiaison = monManager.chargementLiaisonBD();
            afficherLiaison();
        }
    }
}
