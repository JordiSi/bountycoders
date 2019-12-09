using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dades;
using CustomControls;
using Base;
using UserCategories;

namespace UserCategories
{
    public partial class frm_UserCategories : Base.frm_Base
    {
        public frm_UserCategories()
        {
            InitializeComponent();
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
            this.btn_Nou.Click += new System.EventHandler(this.btn_Nou_Click);
        }
    }
}
