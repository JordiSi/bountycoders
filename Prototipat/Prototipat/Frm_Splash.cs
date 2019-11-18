using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taula_opcions;

namespace Prototipat
{
    public partial class Form_splash : Form
    {
        public Form_splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
                label1.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Form_principal frm = new Form_principal();
                frm.Show();
                this.Hide();
            }
            
        }
    }
}
