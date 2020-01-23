using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Data.SqlClient;
using Dades;

namespace Prototipat
{
    public partial class Form_login : Form
    {
        public DataSet dts;
        private Class1 dades;
        private SqlConnection conn;
        public Form_splash frmSplash;
        public Form_principal frmMenu;

        public Form_login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dades = new Dades.Class1();
            txt_user.ForeColor = Color.Gray;
            txt_user.Text = "User";
            txt_password.Text = "Password";
            txt_password.ForeColor = Color.Gray;

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = @"C:\Users\admin\Documents\GitHub\bountycoders\Prototipat\Prototipat\Resources\star wars cantina.mp3";
            wplayer.controls.play();
            //WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            //wplayer.playlistCollection.newPlaylist("star wars cantina.mp3");
            ////wplayer.controls.play();
            //wplayer.PlayStateChange += wplayer_PlayStateChange;
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.ForeColor == Color.Gray)
            {
                txt_user.ForeColor = Color.Black;
                txt_user.Text = "";
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.ForeColor = Color.Gray;
                txt_user.Text = "User";
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.ForeColor == Color.Gray)
            {
                txt_password.ForeColor = Color.Black;
                txt_password.Text = "";
                txt_password.PasswordChar = '*';
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.ForeColor = Color.Gray;
                txt_password.Text = "Password";
                txt_password.PasswordChar = char.Parse("\0");
            }
        }

        //<<<<<<< HEAD
        private void successfulLogin()
        { 
            Form_splash frm;
            if (frmSplash != null)
            {
                frm = frmSplash;
            }
            else
            {
                frm = new Form_splash();
            }
            frm.Show();
            frm.frmLogin = this;
            if (frmMenu != null)
                frm.frmMenu = frmMenu;
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form_splash frm;
            if (frmSplash != null)
            {
                frm = frmSplash;
            }
            else
            {
                frm = new Form_splash();
            }
            frm.accesslevel = 100;
            frm.Show();
            frm.frmLogin = this;
            if (frmMenu != null)
                frm.frmMenu = frmMenu;
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            int accesslevel;
            string query = "select AccessLevel from Users, usercategories ";
            if (txt_user.Text != "" && txt_password.Text != "")
            {
                conn = dades.Connexio();
                conn.Open();
                query += "where users.idUserCategory=usercategories.idUserCategory and UserName=" + "'" + txt_user.Text + "'" + " and Password=" + "'" + txt_password.Text + "'";
                SqlCommand cmdBuilder = new SqlCommand(query, conn);
                SqlDataReader reader = cmdBuilder.ExecuteReader();
                

                if (reader.Read())
                {
                    accesslevel = reader.GetInt32(0);
                    Form_splash frm;
                    if (frmSplash != null)
                    {
                        frm = frmSplash;
                    }
                    else
                    {
                        frm = new Form_splash();
                    }
                    conn.Close();
                    frm.accesslevel = accesslevel;
                    frm.Show();
                    frm.frmLogin = this;
                    if (frmMenu != null)
                        frm.frmMenu = frmMenu;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login incorrecte");
                }
            }
            else
            {
                MessageBox.Show("Introdueix les dades");
            }
        }
    }
}