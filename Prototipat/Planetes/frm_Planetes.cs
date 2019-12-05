using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dades;
using Base;
using Planetes;
using CustomControls;

namespace Planetes
{
    public partial class frm_Planetes : Base.frm_Base
    {
        private DataRow row;
        private DataSet dts;
        private Class1 dades;
        string query;
        


        public frm_Planetes()
        {
            InitializeComponent();
            dades = new Dades.Class1();
            query = "select * from " + this.taula;
            dts = dades.PortarTaula(query);
            dtgUsers.DataSource = dts.Tables[0];
            carregarCamps();

            

        }
        //private void frm_Planetes_Load(object sender, EventArgs e)
        //{
        //    combo.ControlCombo();
        //}

        private void btn_updateDTG_Click(object sender, EventArgs e)
        {

            btn_updateDTG.Text = "UPDATE";
            if (btn_Nou.Visible == false)
            {
                crear();
            }
            dades.Actualitzar(query, dts);
            dts = dades.PortarTaula(query);
            dtgUsers.DataSource = dts.Tables[0];
            carregarCamps();
            //MessageBox.Show(res + " Valores Cambiados");
            btn_Nou.Visible = true;
        }
        private void btn_Nou_Click(object sender, EventArgs e)
        {
            foreach (Control ctr1 in this.Controls)
            {
                if (!((ctr1 is Button) || ctr1 is Label || ctr1 is ComboBoxFK))
                {
                    if (ctr1 is CustomControls.SWTextBox){
                        if(((CustomControls.SWTextBox)ctr1).Foranea == false)
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
            //combo.ControlCombo();
        }

        private void crear()
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
            dtgUsers.DataSource = dts.Tables[0];
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

                if (ctr1.GetType() == typeof(CustomControls.ComboBoxFK))
                {
                    ((CustomControls.ComboBoxFK)ctr1).CarregaDades();
                }
            }
        }



        //private void ControlCombo()
        //{
        //    foreach (Control ctr1 in this.Controls)
        //    {
        //        if (ctr1.GetType() == typeof(ComboBoxFK))
        //        {
        //            foreach (Control ctr2 in this.Controls)
        //            {
        //                if (ctr2.GetType() == typeof(CustomControls.SWTextBox))
        //                {
        //                    if (((ComboBoxFK)ctr1).controlID == ((CustomControls.SWTextBox)ctr2).Name)
        //                    {
        //                        ((CustomControls.SWTextBox)ctr2).Text = ((ComboBoxFK)ctr1).SelectedValue.ToString();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

    }
}
