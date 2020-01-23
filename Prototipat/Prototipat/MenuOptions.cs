
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Planetes;
using Filiations;
using Regions;
using Routes;
using RouteTypes;
using Sectors;
using Species;
using UserCategories;
using UserRanks;
using Users;
using Dades;
using System.Data.SqlClient;

namespace Prototipat
{
	public partial class Form_principal : Form
	{
        private int accesslevel_usuari, accesslevel_taula;

        private Class1 dades;
        private SqlConnection conn;
        private string query;
        public Form_principal(int accesslevel_t)
		{
			InitializeComponent();
            accesslevel_usuari = accesslevel_t;
		}
        private void Form_principal_Load(object sender, EventArgs e)
        {
            dades = new Dades.Class1();
            conn = dades.Connexio();
            try
            {
                conn.Close();
            }
            catch (Exception ex) { }
            
            foreach (Control ctr1 in this.Controls)
            {
                if(ctr1.Name.Equals("menuStrip1"))
                {
                    foreach (ToolStripMenuItem ctr2 in ((MenuStrip)ctr1).Items)
                    {
                        if (ctr2.Text != "Login" && ctr2.Text != "Sortir")
                        {
                            conn.Open();
                            query = "select accesslevel from menuaccess where table_name=" + "'" + ctr2.Text + "'";
                            SqlCommand cmdBuilder = new SqlCommand(query, conn);
                            var dataset = dades.PortarTaula(query);
                                accesslevel_taula = (int)dataset.Tables[0].Rows[0][0];
                            if (accesslevel_taula > accesslevel_usuari)
                            {
                                ctr2.Visible = false;
                            }
                            conn.Close();
                        }
                    }
                }
            }
            
        }
		private void planetesToolStripMenuItem_Click(object sender,EventArgs e) {
			frm_Planetes  frm = new frm_Planetes();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
        }
		private void filiationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Filiations frm = new frm_Filiations();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Regions frm = new frm_Regions();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void routesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Routes frm = new frm_Routes();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void routeTypesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_RouteTypes frm = new frm_RouteTypes();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void sectorsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Sectors frm = new frm_Sectors();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void speciesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Species frm = new frm_Species();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void userCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_UserCategories frm = new frm_UserCategories();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void userRanksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_UserRanks frm = new frm_UserRanks();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void usersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Users frm = new frm_Users();
			frm.MdiParent = this;
			frm.Show();
			ocultar();
		}
		private void frmPrincipal_FormClosing(object sender,FormClosingEventArgs e) {
			 Application.Exit();
		}

		private void sortirToolStripMenuItem_Click(object sender,EventArgs e) {
            this.Close();
        }

		private void loginToolStripMenuItem_Click(object sender,EventArgs e) {
            //Form_login frm;
            //frm.Show();
			//this.Hide();

		}
		public void ocultar()
		{
			pictureBox1.Visible = false;
            
            
		}


    }
}
