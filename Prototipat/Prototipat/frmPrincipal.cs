using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipat
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

		private void opcio1ToolStripMenuItem_Click(object sender,EventArgs e) {

		}

		private void frmPrincipal_FormClosing(object sender,FormClosingEventArgs e) {
			 Environment.Exit(0);
		}

		//MenuStrip.ControlCollection
	}
}
