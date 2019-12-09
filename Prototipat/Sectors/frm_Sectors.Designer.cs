namespace Sectors
{
    partial class frm_Sectors
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
            this.TB_codesector = new CustomControls.SWTextBox();
            this.TB_descsector = new CustomControls.SWTextBox();
            this.CB_idregion = new CustomControls.ComboBoxFK();
            this.TB_idregion = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_codesector
            // 
            this.TB_codesector.CampoBD = "codesector";
            this.TB_codesector.Foranea = false;
            this.TB_codesector.IdCombobox = null;
            this.TB_codesector.Llenar = false;
            this.TB_codesector.Location = new System.Drawing.Point(93, 85);
            this.TB_codesector.Name = "TB_codesector";
            this.TB_codesector.Size = new System.Drawing.Size(100, 20);
            this.TB_codesector.TabIndex = 31;
            this.TB_codesector.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_descsector
            // 
            this.TB_descsector.CampoBD = "descsector";
            this.TB_descsector.Foranea = false;
            this.TB_descsector.IdCombobox = null;
            this.TB_descsector.Llenar = false;
            this.TB_descsector.Location = new System.Drawing.Point(93, 128);
            this.TB_descsector.Name = "TB_descsector";
            this.TB_descsector.Size = new System.Drawing.Size(100, 20);
            this.TB_descsector.TabIndex = 32;
            this.TB_descsector.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // CB_idregion
            // 
            this.CB_idregion.controlID = "TB_idregion";
            this.CB_idregion.DisplayMember = "descregion";
            this.CB_idregion.FormattingEnabled = true;
            this.CB_idregion.Location = new System.Drawing.Point(266, 84);
            this.CB_idregion.Name = "CB_idregion";
            this.CB_idregion.Size = new System.Drawing.Size(121, 21);
            this.CB_idregion.TabIndex = 33;
            this.CB_idregion.taulaBD = "regions";
            this.CB_idregion.ValueMember = "idregion";
            // 
            // TB_idregion
            // 
            this.TB_idregion.CampoBD = "idregion";
            this.TB_idregion.Enabled = false;
            this.TB_idregion.Foranea = true;
            this.TB_idregion.IdCombobox = "CB_idregion";
            this.TB_idregion.Llenar = false;
            this.TB_idregion.Location = new System.Drawing.Point(393, 85);
            this.TB_idregion.Name = "TB_idregion";
            this.TB_idregion.Size = new System.Drawing.Size(100, 20);
            this.TB_idregion.TabIndex = 34;
            this.TB_idregion.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "CodeSector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "DescSector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "IdRegion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frm_Sectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_idregion);
            this.Controls.Add(this.CB_idregion);
            this.Controls.Add(this.TB_descsector);
            this.Controls.Add(this.TB_codesector);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Sectors";
            this.taula = "sectors";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.TB_codesector, 0);
            this.Controls.SetChildIndex(this.TB_descsector, 0);
            this.Controls.SetChildIndex(this.CB_idregion, 0);
            this.Controls.SetChildIndex(this.TB_idregion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox TB_codesector;
        private CustomControls.SWTextBox TB_descsector;
        private CustomControls.ComboBoxFK CB_idregion;
        private CustomControls.SWTextBox TB_idregion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
