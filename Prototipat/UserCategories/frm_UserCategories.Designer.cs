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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_codecategory
            // 
            this.TB_codecategory.CampoBD = "codecategory";
            this.TB_codecategory.Foranea = false;
            this.TB_codecategory.IdCombobox = null;
            this.TB_codecategory.Llenar = false;
            this.TB_codecategory.Location = new System.Drawing.Point(104, 88);
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
            this.TB_accesslevel.Location = new System.Drawing.Point(293, 88);
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
            this.TB_desccategory.Location = new System.Drawing.Point(104, 126);
            this.TB_desccategory.Name = "TB_desccategory";
            this.TB_desccategory.Size = new System.Drawing.Size(100, 20);
            this.TB_desccategory.TabIndex = 34;
            this.TB_desccategory.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "CodeCategory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "DescCategory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "AccessLevel";
            // 
            // frm_UserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox TB_codecategory;
        private CustomControls.SWTextBox TB_accesslevel;
        private CustomControls.SWTextBox TB_desccategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
