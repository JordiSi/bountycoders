namespace Species
{
    partial class frm_Species
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
            this.TB_codespecie = new CustomControls.SWTextBox();
            this.TB_descspecie = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_codespecie
            // 
            this.TB_codespecie.CampoBD = "codespecie";
            this.TB_codespecie.Foranea = false;
            this.TB_codespecie.IdCombobox = null;
            this.TB_codespecie.Llenar = false;
            this.TB_codespecie.Location = new System.Drawing.Point(95, 85);
            this.TB_codespecie.Name = "TB_codespecie";
            this.TB_codespecie.Size = new System.Drawing.Size(100, 20);
            this.TB_codespecie.TabIndex = 32;
            this.TB_codespecie.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_descspecie
            // 
            this.TB_descspecie.CampoBD = "descspecie";
            this.TB_descspecie.Foranea = false;
            this.TB_descspecie.IdCombobox = null;
            this.TB_descspecie.Llenar = false;
            this.TB_descspecie.Location = new System.Drawing.Point(95, 130);
            this.TB_descspecie.Name = "TB_descspecie";
            this.TB_descspecie.Size = new System.Drawing.Size(100, 20);
            this.TB_descspecie.TabIndex = 33;
            this.TB_descspecie.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "CodeSpecie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "DescSpecie";
            // 
            // frm_Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_descspecie);
            this.Controls.Add(this.TB_codespecie);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Species";
            this.taula = "Species";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.TB_codespecie, 0);
            this.Controls.SetChildIndex(this.TB_descspecie, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.SWTextBox TB_codespecie;
        private CustomControls.SWTextBox TB_descspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
