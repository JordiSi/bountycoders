using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dades;

namespace Prototipat
{
    public partial class Sign_In : Form
    {
        public Form_login frmLogin;
        public Class1 dades; 

        public Sign_In()
        {
            InitializeComponent();
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            foreach (Control ctrs in frmLogin.Controls)
            {
                ctrs.Enabled = false;
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "" && Login_txt.Text == "" && Password_txt.Text == "")
            {
                dades.Actualitzar()
            }
        }
    }
}
