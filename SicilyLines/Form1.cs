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
    public partial class Form1 : Form
    {
        Mgr monManager;

        List<Liaison> lEmp = new List<Liaison>();


        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        
        public void affiche()

        {


            try
            {


                lbLiaison.DataSource = null;
                lbLiaison.DataSource = lEmp;
                lbLiaison.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lEmp = monManager.chargementLiaisonsBD();


            affiche();
        }
    }
}
