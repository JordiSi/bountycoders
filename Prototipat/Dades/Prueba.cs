using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dades
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        public void prova()
        {
            Prueba frm = new Prueba();
            frm.ShowDialog();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
