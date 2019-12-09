namespace UserCategories
{
    partial class frm_UserCategories
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_codecategory = new CustomControls.SWTextBox();
            this.TB_accesslevel = new CustomControls.SWTextBox();
            this.TB_desccategory = new CustomControls.SWTextBox();
            this.SuspendLayout();
            // 
            // TB_codecategory
            // 
            this.TB_codecategory.CampoBD = "codecategory";
            this.TB_codecategory.Foranea = false;
            this.TB_codecategory.IdCombobox = null;
            this.TB_codecategory.Llenar = false;
            this.TB_codecategory.Location = new System.Drawing.Point(54, 88);
            this.TB_codecategory.Name = "TB_codecategory";
            this.TB_codecategory.Size = new System.Drawing.Size(100, 20);
            this.TB_codecategory.TabIndex = 32;
            this.TB_codecategory.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_accesslevel
            // 
            this.TB_accesslevel.CampoBD = "accesslevel";
            this.TB_accesslevel.Foranea = false;
            this.TB_accesslevel.IdCombobox = null;
            this.TB_accesslevel.Llenar = false;
            this.TB_accesslevel.Location = new System.Drawing.Point(183, 88);
            this.TB_accesslevel.Name = "TB_accesslevel";
            this.TB_accesslevel.Size = new System.Drawing.Size(100, 20);
            this.TB_accesslevel.TabIndex = 33;
            this.TB_accesslevel.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_desccategory
            // 
            this.TB_desccategory.CampoBD = "desccategory";
            this.TB_desccategory.Foranea = false;
            this.TB_desccategory.IdCombobox = null;
            this.TB_desccategory.Llenar = false;
            this.TB_desccategory.Location = new System.Drawing.Point(54, 127);
            this.TB_desccategory.Name = "TB_desccategory";
            this.TB_desccategory.Size = new System.Drawing.Size(100, 20);
            this.TB_desccategory.TabIndex = 34;
            this.TB_desccategory.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // frm_UserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.TB_desccategory);
            this.Controls.Add(this.TB_accesslevel);
            this.Controls.Add(this.TB_codecategory);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_UserCategories";
            this.taula = "usercategories";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.TB_codecategory, 0);
            this.Controls.SetChildIndex(this.TB_accesslevel, 0);
            this.Controls.SetChildIndex(this.TB_desccategory, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox TB_codecategory;
        private CustomControls.SWTextBox TB_accesslevel;
        private CustomControls.SWTextBox TB_desccategory;
    }
}
