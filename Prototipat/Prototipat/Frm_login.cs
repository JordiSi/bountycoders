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
    public partial class Form1: Form
    {
        private string user = "bountycoders", password = "12345aA";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_user.ForeColor = Color.Gray;
            txt_user.Text = "User";
            txt_password.Text = "Password";
            txt_password.ForeColor = Color.Gray;
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            if (txt_user.ForeColor == Color.Gray) {
                txt_user.ForeColor = Color.Black;
                txt_user.Text = "";
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "") {
                txt_user.ForeColor = Color.Gray;
                txt_user.Text = "User";
            }
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.ForeColor == Color.Gray) {
                txt_password.ForeColor = Color.Black;
                txt_password.Text = "";
                txt_password.PasswordChar = '*';
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "") {
                txt_password.ForeColor = Color.Gray;
                txt_password.Text = "Password";
                txt_password.PasswordChar = char.Parse("\0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Splash frm = new Splash();
            this.Hide();
            frm.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == user && txt_password.Text == password)
            {
                Splash frm = new Splash();
                this.Hide();
                frm.Show();
            }
            else {
                MessageBox.Show("Login incorrecte");
            }
        }
    }
}
