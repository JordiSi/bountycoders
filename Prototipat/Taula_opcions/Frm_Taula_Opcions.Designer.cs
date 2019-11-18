namespace Prototipat
{
    partial class Form_taulaOpcions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_taulaOpcions));
			this.dtgUsers = new System.Windows.Forms.DataGridView();
			this.btn_loadDTG = new System.Windows.Forms.Button();
			this.btn_updateDTG = new System.Windows.Forms.Button();
			this.btn_executeDTG = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.swTextBox6 = new CustomControls.SWTextBox();
			this.swTextBox5 = new CustomControls.SWTextBox();
			this.swTextBox4 = new CustomControls.SWTextBox();
			this.swTextBox3 = new CustomControls.SWTextBox();
			this.swTextBox2 = new CustomControls.SWTextBox();
			this.swTextBox1 = new CustomControls.SWTextBox();
			this.comboBoxFK1 = new CustomControls.ComboBoxFK();
			this.comboBoxFK2 = new CustomControls.ComboBoxFK();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "CodePlanet";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(198, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "DescPlanet";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(405, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "idSector";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(629, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "long";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(55, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "lat";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(216, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "parsecs";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(400, 135);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "idNatives";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(606, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "idFiliation";
			// 
			// swTextBox6
			// 
			this.swTextBox6.CampoBD = "parsecs";
			this.swTextBox6.Foranea = false;
			this.swTextBox6.Llenar = false;
			this.swTextBox6.Location = new System.Drawing.Point(266, 132);
			this.swTextBox6.Name = "swTextBox6";
			this.swTextBox6.Size = new System.Drawing.Size(100, 20);
			this.swTextBox6.TabIndex = 11;
			this.swTextBox6.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
			// 
			// swTextBox5
			// 
			this.swTextBox5.CampoBD = "lat";
			this.swTextBox5.Foranea = false;
			this.swTextBox5.Llenar = false;
			this.swTextBox5.Location = new System.Drawing.Point(79, 132);
			this.swTextBox5.Name = "swTextBox5";
			this.swTextBox5.Size = new System.Drawing.Size(100, 20);
			this.swTextBox5.TabIndex = 10;
			this.swTextBox5.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
			// 
			// swTextBox4
			// 
			this.swTextBox4.CampoBD = "long";
			this.swTextBox4.Foranea = false;
			this.swTextBox4.Llenar = false;
			this.swTextBox4.Location = new System.Drawing.Point(662, 88);
			this.swTextBox4.Name = "swTextBox4";
			this.swTextBox4.Size = new System.Drawing.Size(100, 20);
			this.swTextBox4.TabIndex = 9;
			this.swTextBox4.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
			// 
			// swTextBox3
			// 
			this.swTextBox3.CampoBD = "idSector";
			this.swTextBox3.Foranea = false;
			this.swTextBox3.Llenar = false;
			this.swTextBox3.Location = new System.Drawing.Point(457, 88);
			this.swTextBox3.Name = "swTextBox3";
			this.swTextBox3.Size = new System.Drawing.Size(100, 20);
			this.swTextBox3.TabIndex = 8;
			this.swTextBox3.TipoValor = CustomControls.SWTextBox.TipoDato.Codigo;
			// 
			// swTextBox2
			// 
			this.swTextBox2.CampoBD = "DescPlanet";
			this.swTextBox2.Foranea = false;
			this.swTextBox2.Llenar = false;
			this.swTextBox2.Location = new System.Drawing.Point(266, 91);
			this.swTextBox2.Name = "swTextBox2";
			this.swTextBox2.Size = new System.Drawing.Size(100, 20);
			this.swTextBox2.TabIndex = 7;
			this.swTextBox2.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
			// 
			// swTextBox1
			// 
			this.swTextBox1.CampoBD = "CodePlanet";
			this.swTextBox1.Foranea = false;
			this.swTextBox1.Llenar = false;
			this.swTextBox1.Location = new System.Drawing.Point(79, 88);
			this.swTextBox1.Name = "swTextBox1";
			this.swTextBox1.Size = new System.Drawing.Size(100, 20);
			this.swTextBox1.TabIndex = 6;
			this.swTextBox1.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
			// 
			// comboBoxFK1
			// 
			this.comboBoxFK1.FormattingEnabled = true;
			this.comboBoxFK1.Location = new System.Drawing.Point(457, 131);
			this.comboBoxFK1.Name = "comboBoxFK1";
			this.comboBoxFK1.Size = new System.Drawing.Size(100, 21);
			this.comboBoxFK1.TabIndex = 22;
			// 
			// comboBoxFK2
			// 
			this.comboBoxFK2.FormattingEnabled = true;
			this.comboBoxFK2.Location = new System.Drawing.Point(662, 131);
			this.comboBoxFK2.Name = "comboBoxFK2";
			this.comboBoxFK2.Size = new System.Drawing.Size(100, 21);
			this.comboBoxFK2.TabIndex = 23;
			// 
			// Form_taulaOpcions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(960, 516);
			this.Controls.Add(this.comboBoxFK2);
			this.Controls.Add(this.comboBoxFK1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.swTextBox6);
			this.Controls.Add(this.swTextBox5);
			this.Controls.Add(this.swTextBox4);
			this.Controls.Add(this.swTextBox3);
			this.Controls.Add(this.swTextBox2);
			this.Controls.Add(this.swTextBox1);
			this.Controls.Add(this.btn_executeDTG);
			this.Controls.Add(this.btn_updateDTG);
			this.Controls.Add(this.btn_loadDTG);
			this.Controls.Add(this.dtgUsers);
			this.Name = "Form_taulaOpcions";
			this.Text = "Taula";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.Button btn_loadDTG;
        private System.Windows.Forms.Button btn_updateDTG;
        private System.Windows.Forms.Button btn_executeDTG;
        public CustomControls.SWTextBox swTextBox1;
        private CustomControls.SWTextBox swTextBox2;
        private CustomControls.SWTextBox swTextBox3;
        private CustomControls.SWTextBox swTextBox4;
        private CustomControls.SWTextBox swTextBox5;
        private CustomControls.SWTextBox swTextBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomControls.ComboBoxFK comboBoxFK1;
        private CustomControls.ComboBoxFK comboBoxFK2;
    }
}