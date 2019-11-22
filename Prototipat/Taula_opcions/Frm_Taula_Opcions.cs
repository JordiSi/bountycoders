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
			foreach (Control ctr in this.Controls)
			{
				ctr.Visible = true;
			}

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

		//private void btn_executedtg_click(object sender, eventargs e)
		//{
  //          dades.executa(dts);
  //      }
		public void prova()
		{
			Form_taulaOpcions frm = new Form_taulaOpcions();
			frm.ShowDialog();
		}

		private void btn_Nou_Click(object sender, EventArgs e)
		{

			foreach (Control ctr1 in this.Controls)
			{
				if(!((ctr1.GetType() == btn_updateDTG.GetType()) || (ctr1.GetType() == label1.GetType())|| (ctr1.GetType() == CB_IdFiliation.GetType()))){
					ctr1.DataBindings.Clear();
					ctr1.Text = "";
				}
			}

		}
	}
	}
