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
using ComboFK;

namespace Prototipat
{
	public partial class Form_taulaOpcions : Form
	{
		private DataSet dts;
		private Dades.Class1 dades;
        string query = "select * from planets";
        DataColumn column;

        public Form_taulaOpcions()
		{
			InitializeComponent();

			dades = new Dades.Class1();
            dts = dades.PortarTaula(query);
            dtgUsers.DataSource = dts.Tables[0];
            carregarCamps();

        }

		private void btn_updateDTG_Click(object sender, EventArgs e)
		{

            btn_updateDTG.Text = "UPDATE";
            dades.Actualitzar(query, dts);
            carregarCamps();
            if (btn_Nou.Visible == false)
            {
                crear();
            }
            btn_Nou.Visible = true;
        }
        private void btn_Nou_Click(object sender, EventArgs e)
        {
            foreach (Control ctr1 in this.Controls)
            {
                if (!((ctr1.GetType() == btn_updateDTG.GetType()) || (ctr1.GetType() == label1.GetType()) || (ctr1.GetType() == CB_IdFiliation.GetType())))
                {
                    ctr1.DataBindings.Clear();
                    ctr1.Text = "";
                }
            }
            btn_Nou.Visible = false;

        }

        private void crear()
        {
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1.GetType() == typeof(CustomControls.SWTextBox))
                {
                    column = new DataColumn();
                    column.ColumnName = ((CustomControls.SWTextBox)ctr1).CampoBD;
                    dts.Tables[1].Columns.Add(column);
                }
                if (ctr1.GetType() == typeof(ComboFK.ComboBoxFK))
                {
                    column = new DataColumn();
                    foreach(Control ctr2 in this.Controls)
                    {
                        if (ctr2.GetType() == typeof(CustomControls.SWTextBox))
                        {
                            if (((ComboBoxFK)ctr1).controlID == ((CustomControls.SWTextBox)ctr2).Name)
                            {
                                column.ColumnName = ((CustomControls.SWTextBox)ctr2).CampoBD;
                            }
                        }
                    }

                    dts.Tables[0].Columns.Add(column);
                    dtgUsers.DataSource = dts.Tables[0];
                }
            }


        }

        private void carregarCamps()
        {
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1.GetType() == typeof(CustomControls.SWTextBox))
                {
                    ctr1.DataBindings.Clear();
                    ctr1.DataBindings.Add("Text", dts.Tables[0], ((CustomControls.SWTextBox)ctr1).CampoBD);
                }

                if (ctr1.GetType() == typeof(ComboFK.ComboBoxFK))
                {
                    ((ComboFK.ComboBoxFK)ctr1).CarregaDades();
                }

            }
        }

        public void prova()
        {
            Form_taulaOpcions frm = new Form_taulaOpcions();
            frm.ShowDialog();
        }
    }
	}
