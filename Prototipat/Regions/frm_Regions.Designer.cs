﻿namespace Regions
{
    partial class frm_Regions
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
            this.swTextBox4 = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampoBD = "coderegion";
            this.swTextBox1.Foranea = false;
            this.swTextBox1.IdCombobox = null;
            this.swTextBox1.Llenar = false;
            this.swTextBox1.Location = new System.Drawing.Point(102, 69);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 20);
            this.swTextBox1.TabIndex = 31;
            this.swTextBox1.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampoBD = "descregion";
            this.swTextBox2.Foranea = false;
            this.swTextBox2.IdCombobox = null;
            this.swTextBox2.Llenar = false;
            this.swTextBox2.Location = new System.Drawing.Point(102, 104);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(100, 20);
            this.swTextBox2.TabIndex = 32;
            this.swTextBox2.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // swTextBox4
            // 
            this.swTextBox4.CampoBD = "remarks";
            this.swTextBox4.Foranea = false;
            this.swTextBox4.IdCombobox = null;
            this.swTextBox4.Llenar = false;
            this.swTextBox4.Location = new System.Drawing.Point(336, 69);
            this.swTextBox4.Multiline = true;
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(612, 84);
            this.swTextBox4.TabIndex = 34;
            this.swTextBox4.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "CodeRegion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "DescRegion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Remarks";
            // 
            // frm_Regions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Regions";
            this.taula = "Regions";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.swTextBox1, 0);
            this.Controls.SetChildIndex(this.swTextBox2, 0);
            this.Controls.SetChildIndex(this.swTextBox4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
        private CustomControls.SWTextBox swTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
