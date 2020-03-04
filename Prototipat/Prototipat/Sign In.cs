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
using System.Data.SqlClient;
using Encriptacio;


namespace Prototipat
{
    public partial class Sign_In : Form
    {
        public Form_login frmLogin;
        public Class1 dades;
        public DataSet dts;
        private DataRow row;
        private Encriptar E;
        private String[] array = new String[5];

        public Sign_In()
        {
            InitializeComponent();

        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            E = new Encriptar();
            dades = new Dades.Class1();
            foreach (Control ctrs in frmLogin.Controls)
            {
                ctrs.Enabled = false;
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {

            if ((Login_txt.Text != "" && Password_txt.Text != "" && Cnf_Password.Text != "") && (Cnf_Password.Text==Password_txt.Text))
            {
                dts = dades.PortarTaula("select * from users");
                crear();
                dades.Actualitzar("select * from users",dts);
                MessageBox.Show("Usuari Creat Satisfactòriament");
                this.Close();
            }
        }
        protected void crear()
        {
            row = dts.Tables[0].NewRow();
            row["CodeUser"] = Login_txt.Text.Substring(0,2).ToUpper();
            row["Username"] = Login_txt.Text;
            row["Login"] = "4";
            row["Password"] = E.CrearHash(Password_txt.Text.Trim());
            row["iduserrank"] = 7;
            row["idusercategory"] = 5;
            row["Photo"] = "Hola";
            row["idplanet"] = 13;
            row["idspecie"] = 3;
            dts.Tables[0].Rows.Add(row);
        }

        private void Sign_In_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control ctrs in frmLogin.Controls)
            {
                ctrs.Enabled = true;
            }
            frmLogin.Focus();
        }
    }
}
