namespace Prototipat
{
    partial class Taula
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taula));
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.btn_loadDTG = new System.Windows.Forms.Button();
            this.btn_updateDTG = new System.Windows.Forms.Button();
            this.btn_executeDTG = new System.Windows.Forms.Button();
            this.Consulta = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsers
            // 
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(12, 184);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.Size = new System.Drawing.Size(936, 320);
            this.dtgUsers.TabIndex = 1;
            // 
            // btn_loadDTG
            // 
            this.btn_loadDTG.Location = new System.Drawing.Point(31, 22);
            this.btn_loadDTG.Name = "btn_loadDTG";
            this.btn_loadDTG.Size = new System.Drawing.Size(100, 33);
            this.btn_loadDTG.TabIndex = 2;
            this.btn_loadDTG.Text = "LOAD";
            this.btn_loadDTG.UseVisualStyleBackColor = true;
            this.btn_loadDTG.Click += new System.EventHandler(this.btn_loadDTG_Click);
            // 
            // btn_updateDTG
            // 
            this.btn_updateDTG.Location = new System.Drawing.Point(174, 23);
            this.btn_updateDTG.Name = "btn_updateDTG";
            this.btn_updateDTG.Size = new System.Drawing.Size(100, 32);
            this.btn_updateDTG.TabIndex = 3;
            this.btn_updateDTG.Text = "UPDATE";
            this.btn_updateDTG.UseVisualStyleBackColor = true;
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
            // 
            // btn_executeDTG
            // 
            this.btn_executeDTG.Location = new System.Drawing.Point(323, 23);
            this.btn_executeDTG.Name = "btn_executeDTG";
            this.btn_executeDTG.Size = new System.Drawing.Size(100, 33);
            this.btn_executeDTG.TabIndex = 4;
            this.btn_executeDTG.Text = "EXECUTE";
            this.btn_executeDTG.UseVisualStyleBackColor = true;
            this.btn_executeDTG.Click += new System.EventHandler(this.btn_executeDTG_Click);
            // 
            // Consulta
            // 
            this.Consulta.Location = new System.Drawing.Point(457, 22);
            this.Consulta.Multiline = true;
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(413, 34);
            this.Consulta.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Taula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.btn_executeDTG);
            this.Controls.Add(this.btn_updateDTG);
            this.Controls.Add(this.btn_loadDTG);
            this.Controls.Add(this.dtgUsers);
            this.Name = "Taula";
            this.Text = "Taula";
            this.Load += new System.EventHandler(this.Taula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Button btn_loadDTG;
        private System.Windows.Forms.Button btn_updateDTG;
        private System.Windows.Forms.Button btn_executeDTG;
        private System.Windows.Forms.TextBox Consulta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}