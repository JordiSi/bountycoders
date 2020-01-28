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
using Users;

namespace Users
{
    public partial class frm_Users : Base.frm_Base
    {
        public frm_Users()
        {
            InitializeComponent();
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
            this.btn_Nou.Click += new System.EventHandler(this.btn_Nou_Click);
        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bountyCodersDataSet.Users' Puede moverla o quitarla según sea necesario.

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
