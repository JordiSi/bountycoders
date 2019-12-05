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
using CustomControls;

namespace Filiations
{
    public partial class frm_Filiations : Base.frm_Base
    {
        public frm_Filiations()
        {
            InitializeComponent();
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
        }

    }
}
