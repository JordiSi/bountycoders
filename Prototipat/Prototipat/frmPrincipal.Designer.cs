﻿namespace Prototipat
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcio1ToolStripMenuItem,
            this.opcio2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcio1ToolStripMenuItem
            // 
            this.opcio1ToolStripMenuItem.Checked = true;
            this.opcio1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opcio1ToolStripMenuItem.Name = "opcio1ToolStripMenuItem";
            this.opcio1ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.opcio1ToolStripMenuItem.Text = "opcio1";
            // 
            // opcio2ToolStripMenuItem
            // 
            this.opcio2ToolStripMenuItem.Name = "opcio2ToolStripMenuItem";
            this.opcio2ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.opcio2ToolStripMenuItem.Text = "opcio2";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcio2ToolStripMenuItem;
    }
}