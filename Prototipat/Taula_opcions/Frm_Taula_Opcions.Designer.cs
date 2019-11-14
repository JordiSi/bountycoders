namespace Prototipat
{
    partial class Frm_Taula_Opcions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Taula_Opcions));
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.btn_loadDTG = new System.Windows.Forms.Button();
            this.btn_updateDTG = new System.Windows.Forms.Button();
            this.btn_executeDTG = new System.Windows.Forms.Button();
            this.Consulta = new System.Windows.Forms.TextBox();
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.swTextBox3 = new CustomControls.SWTextBox();
            this.swTextBox4 = new CustomControls.SWTextBox();
            this.swTextBox5 = new CustomControls.SWTextBox();
            this.swTextBox6 = new CustomControls.SWTextBox();
            this.swTextBox7 = new CustomControls.SWTextBox();
            this.swTextBox8 = new CustomControls.SWTextBox();
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
            // 
            // Consulta
            // 
            this.Consulta.Location = new System.Drawing.Point(457, 22);
            this.Consulta.Multiline = true;
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(413, 34);
            this.Consulta.TabIndex = 5;
            // 
            // swTextBox1
            // 
            this.swTextBox1.CampoBD = "CodePlanet";
            this.swTextBox1.Foranea = false;
            this.swTextBox1.Llenar = false;
            this.swTextBox1.Location = new System.Drawing.Point(31, 89);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.Size = new System.Drawing.Size(100, 20);
            this.swTextBox1.TabIndex = 6;
            this.swTextBox1.TipoValor = CustomControls.SWTextBox.TipoDato.Codigo;
            // 
            // swTextBox2
            // 
            this.swTextBox2.CampoBD = "DescPlanet";
            this.swTextBox2.Foranea = false;
            this.swTextBox2.Llenar = false;
            this.swTextBox2.Location = new System.Drawing.Point(174, 88);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.Size = new System.Drawing.Size(100, 20);
            this.swTextBox2.TabIndex = 7;
            this.swTextBox2.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // swTextBox3
            // 
            this.swTextBox3.CampoBD = "idSector";
            this.swTextBox3.Foranea = false;
            this.swTextBox3.Llenar = false;
            this.swTextBox3.Location = new System.Drawing.Point(323, 88);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.Size = new System.Drawing.Size(100, 20);
            this.swTextBox3.TabIndex = 8;
            this.swTextBox3.TipoValor = CustomControls.SWTextBox.TipoDato.Codigo;
            // 
            // swTextBox4
            // 
            this.swTextBox4.CampoBD = "long";
            this.swTextBox4.Foranea = false;
            this.swTextBox4.Llenar = false;
            this.swTextBox4.Location = new System.Drawing.Point(467, 88);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.Size = new System.Drawing.Size(100, 20);
            this.swTextBox4.TabIndex = 9;
            this.swTextBox4.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // swTextBox5
            // 
            this.swTextBox5.CampoBD = "lat";
            this.swTextBox5.Foranea = false;
            this.swTextBox5.Llenar = false;
            this.swTextBox5.Location = new System.Drawing.Point(31, 132);
            this.swTextBox5.Name = "swTextBox5";
            this.swTextBox5.Size = new System.Drawing.Size(100, 20);
            this.swTextBox5.TabIndex = 10;
            this.swTextBox5.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // swTextBox6
            // 
            this.swTextBox6.CampoBD = "parsecs";
            this.swTextBox6.Foranea = false;
            this.swTextBox6.Llenar = false;
            this.swTextBox6.Location = new System.Drawing.Point(174, 132);
            this.swTextBox6.Name = "swTextBox6";
            this.swTextBox6.Size = new System.Drawing.Size(100, 20);
            this.swTextBox6.TabIndex = 11;
            this.swTextBox6.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // swTextBox7
            // 
            this.swTextBox7.CampoBD = "idNatives";
            this.swTextBox7.Foranea = false;
            this.swTextBox7.Llenar = false;
            this.swTextBox7.Location = new System.Drawing.Point(323, 132);
            this.swTextBox7.Name = "swTextBox7";
            this.swTextBox7.Size = new System.Drawing.Size(100, 20);
            this.swTextBox7.TabIndex = 12;
            this.swTextBox7.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // swTextBox8
            // 
            this.swTextBox8.CampoBD = "idFiliation";
            this.swTextBox8.Foranea = false;
            this.swTextBox8.Llenar = false;
            this.swTextBox8.Location = new System.Drawing.Point(467, 132);
            this.swTextBox8.Name = "swTextBox8";
            this.swTextBox8.Size = new System.Drawing.Size(100, 20);
            this.swTextBox8.TabIndex = 13;
            this.swTextBox8.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // Frm_Taula_Opcions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.swTextBox8);
            this.Controls.Add(this.swTextBox7);
            this.Controls.Add(this.swTextBox6);
            this.Controls.Add(this.swTextBox5);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.btn_executeDTG);
            this.Controls.Add(this.btn_updateDTG);
            this.Controls.Add(this.btn_loadDTG);
            this.Controls.Add(this.dtgUsers);
            this.Name = "Frm_Taula_Opcions";
            this.Text = "Taula";
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
        public CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
        private CustomControls.SWTextBox swTextBox3;
        private CustomControls.SWTextBox swTextBox4;
        private CustomControls.SWTextBox swTextBox5;
        private CustomControls.SWTextBox swTextBox6;
        private CustomControls.SWTextBox swTextBox7;
        private CustomControls.SWTextBox swTextBox8;
    }
}