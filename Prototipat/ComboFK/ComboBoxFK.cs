﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using Dades;
using System.Data;

namespace ComboFK
{
    public class ComboBoxFK : ComboBox
    {
        private Dades.Class1 dades;

        public string controlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }
        public string taulaBD
        {
            get { return _taulaBD; }
            set { _taulaBD = value; }
        }

        private string _controlID;
        private string _taulaBD;


        public ComboBoxFK()
        {
            dades = new Dades.Class1();
            dades.Connectar();

            this.SuspendLayout();
            this.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxFK_SelectionChangeCommitted);
            this.ResumeLayout(false);


        }


        public void CarregaDades()
        {
            string query = "select* from " + this.taulaBD;
            DataSet dts = new DataSet();

            dts = dades.PortarTaula(query);
            this.DataSource = dts.Tables[0];
        }


        private void ComboBoxFK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Control ctr1 in this.Parent.Controls)
            {
                if (ctr1.GetType() == typeof(ComboBoxFK))
                {
                    foreach(Control ctr2 in this.Parent.Controls)
                    {
                        if (ctr2.GetType() == typeof(CustomControls.SWTextBox))
                        {
                            if (((ComboBoxFK)ctr1).controlID == ((CustomControls.SWTextBox)ctr2).Name)
                            {
                                ((CustomControls.SWTextBox)ctr2).Text = ((ComboBoxFK)ctr1).SelectedValue.ToString();
                            }
                        }
                            
                    }
                }

            }

        }

    }
}
