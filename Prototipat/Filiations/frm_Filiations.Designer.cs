﻿namespace Filiations
{
    partial class frm_Filiations
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
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampoBD = "codefiliation";
            this.swTextBox1.Foranea = false;
            this.swTextBox1.IdCombobox = null;
            this.swTextBox1.Llenar = false;
            this.swTextBox1.Location = new System.Drawing.Point(59, 91);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 20);
            this.swTextBox1.TabIndex = 31;
            this.swTextBox1.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampoBD = "descfiliations";
            this.swTextBox2.Foranea = false;
            this.swTextBox2.IdCombobox = null;
            this.swTextBox2.Llenar = true;
            this.swTextBox2.Location = new System.Drawing.Point(59, 117);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(310, 20);
            this.swTextBox2.TabIndex = 32;
            this.swTextBox2.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // frm_Filiations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Filiations";
            this.taula = "Filiations";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
    }
}
