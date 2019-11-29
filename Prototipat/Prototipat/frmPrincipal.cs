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

namespace Prototipat
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

		private void opcio1ToolStripMenuItem_Click(object sender,EventArgs e) {
			frm_Planetes  frm = new frm_Planetes();
			frm.MdiParent = this;
            frm.Show();
		}

		private void frmPrincipal_FormClosing(object sender,FormClosingEventArgs e) {
			 Environment.Exit(0);
		}

		private void sortirToolStripMenuItem_Click(object sender,EventArgs e) {
			Environment.Exit(0);
		}

		private void loginToolStripMenuItem_Click(object sender,EventArgs e) {
			Form_login frm = new Form_login();
            frm.Show();
            this.Hide();
		}
	}
}
