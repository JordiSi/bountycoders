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
	public partial class Form_taulaOpcions : Form
	{
		private string query;
		private DataSet dts;
		private Dades.Class1 dades;

		public Form_taulaOpcions()
		{
			InitializeComponent();

			dades = new Dades.Class1();
			
		}

		private void btn_loadDTG_Click(object sender, EventArgs e)
		{
			query = "select * from planets";
			dts = dades.PortarTaula(query);
			dtgUsers.DataSource = dts.Tables[0];

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

		private void btn_updateDTG_Click(object sender, EventArgs e)
		{
			dades.Actualitzar(query, dts);
		}

		private void btn_executeDTG_Click(object sender, EventArgs e)
		{
			//    if (Consulta.Text != "")
			//    {
			//        query = Consulta.Text;
			//        dades.Executa(query, dts);
			//    }
			//    else
			//    {
			//        MessageBox.Show("Introdueix un valor per la consulta");
			//    }
		}
		public void prova()
		{
			Form_taulaOpcions frm = new Form_taulaOpcions();
			frm.ShowDialog();
		}
		}
	}
