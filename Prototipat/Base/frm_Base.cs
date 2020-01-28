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
using CustomControls;

namespace Base
{
    public partial class frm_Base : Form
    {
        private DataRow row;
        private DataSet dts;
        private Class1 dades;
        string query;

        public string taula
        {
            get { return _taula; }
            set { _taula = value; }
        }
        private string _taula;

        public frm_Base()
        {
            InitializeComponent();
        }
        protected void btn_updateDTG_Click(object sender, EventArgs e)
        {

            btn_updateDTG.Text = "UPDATE";
            if (btn_Nou.Visible == false)
            {
                if (!comprovar_ple())
                {
                    MessageBox.Show("Omplir tots els camps necessaris");
                }
                else
                {
                    crear();

                    carregarCamps();
                    btn_Nou.Visible = true;
                }
            }
            dades.Actualitzar(query, dts);
            recarregar_taula();
        }
        protected void btn_Nou_Click(object sender, EventArgs e)
        {
            foreach (Control ctr1 in this.Controls)
            {
                if (!((ctr1 is Button) || ctr1 is Label || ctr1 is ComboBoxFK))
                {
                    if (ctr1 is CustomControls.SWTextBox)
                    {
                        if (((CustomControls.SWTextBox)ctr1).Foranea == false)
                        {
                            ctr1.DataBindings.Clear();
                            ctr1.Text = "";
                        }
                        else
                        {
                            ctr1.DataBindings.Clear();
                        }

                    }
                    else
                    {
                        ctr1.DataBindings.Clear();
                        ctr1.Text = "";
                    }

                }
            }
            btn_Nou.Visible = false;
        }

        protected void crear()
        {
            row = dts.Tables[0].NewRow();
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1.GetType() == typeof(CustomControls.SWTextBox))
                {
                    row[((CustomControls.SWTextBox)ctr1).CampoBD] = ctr1.Text;
                }
            }
            dts.Tables[0].Rows.Add(row);
            //recarregar_taula();
        }

        protected void carregarCamps()
        {
            foreach (Control ctr1 in this.Controls)
            {
                if (ctr1.GetType() == typeof(CustomControls.SWTextBox))
                {
                    ctr1.DataBindings.Clear();
                    ctr1.DataBindings.Add("Text", dts.Tables[0], ((CustomControls.SWTextBox)ctr1).CampoBD);
                }

                if (ctr1.GetType() == typeof(CustomControls.ComboBoxFK))
                {
                    ((CustomControls.ComboBoxFK)ctr1).CarregaDades();
                }
            }
        }

        protected void frm_Base_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            dades = new Dades.Class1();
            query = "select * from " + this.taula;
            recarregar_taula();
            carregarCamps();
        }
        protected bool comprovar_ple()
        {
            bool comp = true;
            foreach (Control ctr1 in this.Controls)
            {
                if(ctr1 is SWTextBox)
                {
                    if(ctr1.Text== "")
                    {
                        comp = false;
                    }
                }
            }
            
            return comp;
        }
        protected void recarregar_taula()
        {
            dts = dades.PortarTaula(query);
            dtgUsers.DataSource = dts.Tables[0];
        }
    }
}
