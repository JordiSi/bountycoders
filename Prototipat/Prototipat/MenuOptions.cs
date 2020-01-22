
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

namespace Prototipat
{
	public partial class Form_principal : Form
	{
        //private Form_login = ;

		public Form_principal(string query)
		{
			InitializeComponent();
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
			 Environment.Exit(0);
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
