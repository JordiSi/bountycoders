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
            this.btn_Nou = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Parsecs = new CustomControls.SWTextBox();
            this.TB_Lat = new CustomControls.SWTextBox();
            this.TB_Long = new CustomControls.SWTextBox();
            this.TB_DescPlanet = new CustomControls.SWTextBox();
            this.TB_CodePlanet = new CustomControls.SWTextBox();
            this.TB_IdSector = new CustomControls.SWTextBox();
            this.TB_IdNatives = new CustomControls.SWTextBox();
            this.TB_IdFiliation = new CustomControls.SWTextBox();
            this.CB_IdSector = new ComboFK.ComboBoxFK();
            this.CB_IdFiliation = new ComboFK.ComboBoxFK();
            this.CB_IdNatives = new ComboFK.ComboBoxFK();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsers
            // 
            this.dtgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(12, 184);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.Size = new System.Drawing.Size(936, 320);
            this.dtgUsers.TabIndex = 1;
            // 
            // btn_loadDTG
            // 
            this.btn_loadDTG.BackColor = System.Drawing.Color.Gold;
            this.btn_loadDTG.Location = new System.Drawing.Point(32, 49);
            this.btn_loadDTG.Name = "btn_loadDTG";
            this.btn_loadDTG.Size = new System.Drawing.Size(100, 32);
            this.btn_loadDTG.TabIndex = 2;
            this.btn_loadDTG.Text = "LOAD";
            this.btn_loadDTG.UseVisualStyleBackColor = false;
            this.btn_loadDTG.Click += new System.EventHandler(this.btn_loadDTG_Click);
            // 
            // btn_updateDTG
            // 
            this.btn_updateDTG.BackColor = System.Drawing.Color.Gold;
            this.btn_updateDTG.Location = new System.Drawing.Point(174, 50);
            this.btn_updateDTG.Name = "btn_updateDTG";
            this.btn_updateDTG.Size = new System.Drawing.Size(100, 32);
            this.btn_updateDTG.TabIndex = 3;
            this.btn_updateDTG.Text = "UPDATE";
            this.btn_updateDTG.UseVisualStyleBackColor = false;
            this.btn_updateDTG.Visible = false;
            this.btn_updateDTG.Click += new System.EventHandler(this.btn_updateDTG_Click);
            // 
            // btn_Nou
            // 
            this.btn_Nou.BackColor = System.Drawing.Color.Gold;
            this.btn_Nou.Location = new System.Drawing.Point(319, 50);
            this.btn_Nou.Name = "btn_Nou";
            this.btn_Nou.Size = new System.Drawing.Size(100, 32);
            this.btn_Nou.TabIndex = 4;
            this.btn_Nou.Text = "NOU";
            this.btn_Nou.UseVisualStyleBackColor = false;
            this.btn_Nou.Visible = false;
            this.btn_Nou.Click += new System.EventHandler(this.btn_Nou_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "CodePlanet";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "DescPlanet";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "idSector";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "long";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "lat";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "parsecs";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "idNatives";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "idFiliation";
            this.label8.Visible = false;
            // 
            // TB_Parsecs
            // 
            this.TB_Parsecs.CampoBD = "parsecs";
            this.TB_Parsecs.Foranea = false;
            this.TB_Parsecs.Llenar = false;
            this.TB_Parsecs.Location = new System.Drawing.Point(266, 132);
            this.TB_Parsecs.Name = "TB_Parsecs";
            this.TB_Parsecs.Size = new System.Drawing.Size(100, 20);
            this.TB_Parsecs.TabIndex = 11;
            this.TB_Parsecs.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            this.TB_Parsecs.Visible = false;
            // 
            // TB_Lat
            // 
            this.TB_Lat.CampoBD = "lat";
            this.TB_Lat.Foranea = false;
            this.TB_Lat.Llenar = false;
            this.TB_Lat.Location = new System.Drawing.Point(79, 132);
            this.TB_Lat.Name = "TB_Lat";
            this.TB_Lat.Size = new System.Drawing.Size(100, 20);
            this.TB_Lat.TabIndex = 10;
            this.TB_Lat.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            this.TB_Lat.Visible = false;
            // 
            // TB_Long
            // 
            this.TB_Long.CampoBD = "long";
            this.TB_Long.Foranea = false;
            this.TB_Long.Llenar = false;
            this.TB_Long.Location = new System.Drawing.Point(673, 89);
            this.TB_Long.Name = "TB_Long";
            this.TB_Long.Size = new System.Drawing.Size(100, 20);
            this.TB_Long.TabIndex = 9;
            this.TB_Long.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            this.TB_Long.Visible = false;
            // 
            // TB_DescPlanet
            // 
            this.TB_DescPlanet.CampoBD = "DescPlanet";
            this.TB_DescPlanet.Foranea = false;
            this.TB_DescPlanet.Llenar = false;
            this.TB_DescPlanet.Location = new System.Drawing.Point(266, 91);
            this.TB_DescPlanet.Name = "TB_DescPlanet";
            this.TB_DescPlanet.Size = new System.Drawing.Size(100, 20);
            this.TB_DescPlanet.TabIndex = 7;
            this.TB_DescPlanet.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            this.TB_DescPlanet.Visible = false;
            // 
            // TB_CodePlanet
            // 
            this.TB_CodePlanet.CampoBD = "CodePlanet";
            this.TB_CodePlanet.Foranea = false;
            this.TB_CodePlanet.Llenar = false;
            this.TB_CodePlanet.Location = new System.Drawing.Point(79, 88);
            this.TB_CodePlanet.Name = "TB_CodePlanet";
            this.TB_CodePlanet.Size = new System.Drawing.Size(100, 20);
            this.TB_CodePlanet.TabIndex = 6;
            this.TB_CodePlanet.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            this.TB_CodePlanet.Visible = false;
            // 
            // TB_IdSector
            // 
            this.TB_IdSector.CampoBD = "idSector";
            this.TB_IdSector.Enabled = false;
            this.TB_IdSector.Foranea = true;
            this.TB_IdSector.Llenar = false;
            this.TB_IdSector.Location = new System.Drawing.Point(518, 88);
            this.TB_IdSector.Name = "TB_IdSector";
            this.TB_IdSector.Size = new System.Drawing.Size(39, 20);
            this.TB_IdSector.TabIndex = 25;
            this.TB_IdSector.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            this.TB_IdSector.Visible = false;
            // 
            // TB_IdNatives
            // 
            this.TB_IdNatives.CampoBD = "idNatives";
            this.TB_IdNatives.Enabled = false;
            this.TB_IdNatives.Foranea = true;
            this.TB_IdNatives.Llenar = false;
            this.TB_IdNatives.Location = new System.Drawing.Point(519, 131);
            this.TB_IdNatives.Name = "TB_IdNatives";
            this.TB_IdNatives.Size = new System.Drawing.Size(38, 20);
            this.TB_IdNatives.TabIndex = 26;
            this.TB_IdNatives.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            this.TB_IdNatives.Visible = false;
            // 
            // TB_IdFiliation
            // 
            this.TB_IdFiliation.CampoBD = "idFiliation";
            this.TB_IdFiliation.Enabled = false;
            this.TB_IdFiliation.Foranea = true;
            this.TB_IdFiliation.Llenar = false;
            this.TB_IdFiliation.Location = new System.Drawing.Point(735, 131);
            this.TB_IdFiliation.Name = "TB_IdFiliation";
            this.TB_IdFiliation.Size = new System.Drawing.Size(38, 20);
            this.TB_IdFiliation.TabIndex = 27;
            this.TB_IdFiliation.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            this.TB_IdFiliation.Visible = false;
            // 
            // CB_IdSector
            // 
            this.CB_IdSector.controlID = "TB_IdSector";
            this.CB_IdSector.DisplayMember = "DescSector";
            this.CB_IdSector.FormattingEnabled = true;
            this.CB_IdSector.Location = new System.Drawing.Point(458, 61);
            this.CB_IdSector.Name = "CB_IdSector";
            this.CB_IdSector.Size = new System.Drawing.Size(99, 21);
            this.CB_IdSector.TabIndex = 24;
            this.CB_IdSector.taulaBD = "Sectors";
            this.CB_IdSector.ValueMember = "IdSector";
            this.CB_IdSector.Visible = false;
            // 
            // CB_IdFiliation
            // 
            this.CB_IdFiliation.controlID = "TB_IdFiliation";
            this.CB_IdFiliation.DisplayMember = "DescFiliations";
            this.CB_IdFiliation.FormattingEnabled = true;
            this.CB_IdFiliation.Location = new System.Drawing.Point(673, 131);
            this.CB_IdFiliation.Name = "CB_IdFiliation";
            this.CB_IdFiliation.Size = new System.Drawing.Size(100, 21);
            this.CB_IdFiliation.TabIndex = 23;
            this.CB_IdFiliation.taulaBD = "Filiations";
            this.CB_IdFiliation.ValueMember = "idFiliation";
            this.CB_IdFiliation.Visible = false;
            // 
            // CB_IdNatives
            // 
            this.CB_IdNatives.controlID = "TB_IdNatives";
            this.CB_IdNatives.DisplayMember = "DescSpecie";
            this.CB_IdNatives.FormattingEnabled = true;
            this.CB_IdNatives.Location = new System.Drawing.Point(457, 131);
            this.CB_IdNatives.Name = "CB_IdNatives";
            this.CB_IdNatives.Size = new System.Drawing.Size(100, 21);
            this.CB_IdNatives.TabIndex = 22;
            this.CB_IdNatives.taulaBD = "Species";
            this.CB_IdNatives.ValueMember = "IdSpecie";
            this.CB_IdNatives.Visible = false;
            // 
            // Form_taulaOpcions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.CB_IdNatives);
            this.Controls.Add(this.CB_IdFiliation);
            this.Controls.Add(this.CB_IdSector);
            this.Controls.Add(this.TB_IdFiliation);
            this.Controls.Add(this.TB_IdNatives);
            this.Controls.Add(this.TB_IdSector);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Parsecs);
            this.Controls.Add(this.TB_Lat);
            this.Controls.Add(this.TB_Long);
            this.Controls.Add(this.TB_DescPlanet);
            this.Controls.Add(this.TB_CodePlanet);
            this.Controls.Add(this.btn_Nou);
            this.Controls.Add(this.btn_updateDTG);
            this.Controls.Add(this.btn_loadDTG);
            this.Controls.Add(this.dtgUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btn_Nou;
        public CustomControls.SWTextBox TB_CodePlanet;
        private CustomControls.SWTextBox TB_DescPlanet;
        private CustomControls.SWTextBox TB_Long;
        private CustomControls.SWTextBox TB_Lat;
        private CustomControls.SWTextBox TB_Parsecs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ComboFK.ComboBoxFK CB_IdNatives;
        private ComboFK.ComboBoxFK CB_IdFiliation;
        private ComboFK.ComboBoxFK CB_IdSector;
        private CustomControls.SWTextBox TB_IdSector;
        private CustomControls.SWTextBox TB_IdNatives;
        private CustomControls.SWTextBox TB_IdFiliation;
    }
}