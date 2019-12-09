namespace UserRanks
{
    partial class frm_UserRanks
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
            this.TB_coderank = new CustomControls.SWTextBox();
            this.TB_descrank = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_coderank
            // 
            this.TB_coderank.CampoBD = "coderank";
            this.TB_coderank.Foranea = false;
            this.TB_coderank.IdCombobox = null;
            this.TB_coderank.Llenar = false;
            this.TB_coderank.Location = new System.Drawing.Point(89, 88);
            this.TB_coderank.Name = "TB_coderank";
            this.TB_coderank.Size = new System.Drawing.Size(100, 20);
            this.TB_coderank.TabIndex = 31;
            this.TB_coderank.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_descrank
            // 
            this.TB_descrank.CampoBD = "descrank";
            this.TB_descrank.Foranea = false;
            this.TB_descrank.IdCombobox = null;
            this.TB_descrank.Llenar = false;
            this.TB_descrank.Location = new System.Drawing.Point(88, 129);
            this.TB_descrank.Name = "TB_descrank";
            this.TB_descrank.Size = new System.Drawing.Size(100, 20);
            this.TB_descrank.TabIndex = 32;
            this.TB_descrank.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "CodeRank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "DescRank";
            // 
            // frm_UserRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_descrank);
            this.Controls.Add(this.TB_coderank);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_UserRanks";
            this.taula = "userranks";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.TB_coderank, 0);
            this.Controls.SetChildIndex(this.TB_descrank, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox TB_coderank;
        private CustomControls.SWTextBox TB_descrank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
