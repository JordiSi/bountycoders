namespace Routes
{
    partial class frm_Routes
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
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.CB_idroutetype = new CustomControls.ComboBoxFK();
            this.TB_idroutetype = new CustomControls.SWTextBox();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampoBD = "coderoute";
            this.swTextBox1.Foranea = false;
            this.swTextBox1.IdCombobox = null;
            this.swTextBox1.Llenar = false;
            this.swTextBox1.Location = new System.Drawing.Point(147, 82);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 20);
            this.swTextBox1.TabIndex = 31;
            this.swTextBox1.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampoBD = "descroute";
            this.swTextBox2.Foranea = false;
            this.swTextBox2.IdCombobox = null;
            this.swTextBox2.Llenar = false;
            this.swTextBox2.Location = new System.Drawing.Point(147, 124);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(100, 20);
            this.swTextBox2.TabIndex = 32;
            this.swTextBox2.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // CB_idroutetype
            // 
            this.CB_idroutetype.controlID = "TB_idroutetype";
            this.CB_idroutetype.DisplayMember = "descroutetype";
            this.CB_idroutetype.FormattingEnabled = true;
            this.CB_idroutetype.Location = new System.Drawing.Point(287, 82);
            this.CB_idroutetype.Name = "CB_idroutetype";
            this.CB_idroutetype.Size = new System.Drawing.Size(121, 21);
            this.CB_idroutetype.TabIndex = 33;
            this.CB_idroutetype.taulaBD = "routetypes";
            this.CB_idroutetype.ValueMember = "idroutetype";
            // 
            // TB_idroutetype
            // 
            this.TB_idroutetype.CampoBD = "idroutetype";
            this.TB_idroutetype.Enabled = false;
            this.TB_idroutetype.Foranea = true;
            this.TB_idroutetype.IdCombobox = "CB_idroutetype";
            this.TB_idroutetype.Llenar = false;
            this.TB_idroutetype.Location = new System.Drawing.Point(414, 82);
            this.TB_idroutetype.Name = "TB_idroutetype";
            this.TB_idroutetype.Size = new System.Drawing.Size(100, 20);
            this.TB_idroutetype.TabIndex = 34;
            this.TB_idroutetype.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // frm_Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.TB_idroutetype);
            this.Controls.Add(this.CB_idroutetype);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Routes";
            this.taula = "routes";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.CB_idroutetype, 0);
            this.Controls.SetChildIndex(this.TB_idroutetype, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
        private CustomControls.SWTextBox TB_idroutetype;
        private CustomControls.ComboBoxFK CB_idroutetype;
    }
}
