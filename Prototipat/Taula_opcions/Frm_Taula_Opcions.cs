using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dades;
namespace Prototipat
{
    public partial class Frm_Taula_Opcions : Form
    {
        private string query;
        private DataSet dts;
        private Dades.Class1 dades;

        public Frm_Taula_Opcions()
        {
            InitializeComponent();

            dades = new Dades.Class1();
            dades.Connectar();
        }

        private void btn_loadDTG_Click(object sender, EventArgs e)
        {
            query = "select * from planets";
            dts = dades.PortarTaula(query);
            dtgUsers.DataSource = dts.Tables[0];
            dades.prova();
        }

        private void btn_updateDTG_Click(object sender, EventArgs e)
        {
            dades.Actualitzar(dts);
        }

        private void btn_executeDTG_Click(object sender, EventArgs e)
        {
            if (Consulta.Text != "")
            {
                query = Consulta.Text;
                dades.Executa(query, dts);
            }
            else
            {
                MessageBox.Show("Introdueix un valor per la consulta");
            }
        }
        public void prova()
        {
            Frm_Taula_Opcions frm = new Frm_Taula_Opcions();
            frm.ShowDialog();
            //
        }
    }
}
