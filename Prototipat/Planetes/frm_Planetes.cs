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
        //private DataRow row;
        //private DataSet dts;
        //private Class1 dades;
        //string query;
        


        public frm_Planetes()
        {
            InitializeComponent();
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
            this.btn_Nou.Click += new System.EventHandler(this.btn_Nou_Click);
        }
    }
}
