﻿using System;
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
using Regions;

namespace Regions
{
    public partial class frm_Regions : Base.frm_Base
    {
        public frm_Regions()
        {
            InitializeComponent();
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
            this.btn_Nou.Click += new System.EventHandler(this.btn_Nou_Click);
        }
    }
}
