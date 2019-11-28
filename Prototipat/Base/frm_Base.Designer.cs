namespace Base
{
    partial class frm_Base
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
            this.CB_IdNatives = new ComboFK.ComboBoxFK();
            this.CB_IdFiliation = new ComboFK.ComboBoxFK();
            this.CB_IdSector = new ComboFK.ComboBoxFK();
            this.TB_IdFiliation = new CustomControls.SWTextBox();
            this.TB_IdNatives = new CustomControls.SWTextBox();
            this.TB_IdSector = new CustomControls.SWTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Parsecs = new CustomControls.SWTextBox();
            this.TB_Lat = new CustomControls.SWTextBox();
            this.TB_Long = new CustomControls.SWTextBox();
            this.TB_DescPlanet = new CustomControls.SWTextBox();
            this.TB_CodePlanet = new CustomControls.SWTextBox();
            this.btn_Nou = new System.Windows.Forms.Button();
            this.btn_updateDTG = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_IdNatives
            // 
            this.CB_IdNatives.controlID = "TB_IdNatives";
            this.CB_IdNatives.DisplayMember = "DescSpecie";
            this.CB_IdNatives.FormattingEnabled = true;
            this.CB_IdNatives.Location = new System.Drawing.Point(378, 93);
            this.CB_IdNatives.Name = "CB_IdNatives";
            this.CB_IdNatives.Size = new System.Drawing.Size(100, 21);
            this.CB_IdNatives.TabIndex = 44;
            this.CB_IdNatives.taulaBD = "Species";
            this.CB_IdNatives.ValueMember = "IdSpecie";
            // 
            // CB_IdFiliation
            // 
            this.CB_IdFiliation.controlID = "TB_IdFiliation";
            this.CB_IdFiliation.DisplayMember = "DescFiliations";
            this.CB_IdFiliation.FormattingEnabled = true;
            this.CB_IdFiliation.Location = new System.Drawing.Point(570, 80);
            this.CB_IdFiliation.Name = "CB_IdFiliation";
            this.CB_IdFiliation.Size = new System.Drawing.Size(100, 21);
            this.CB_IdFiliation.TabIndex = 45;
            this.CB_IdFiliation.taulaBD = "Filiations";
            this.CB_IdFiliation.ValueMember = "idFiliation";
            // 
            // CB_IdSector
            // 
            this.CB_IdSector.controlID = "TB_IdSector";
            this.CB_IdSector.DisplayMember = "DescSector";
            this.CB_IdSector.FormattingEnabled = true;
            this.CB_IdSector.Location = new System.Drawing.Point(378, 19);
            this.CB_IdSector.Name = "CB_IdSector";
            this.CB_IdSector.Size = new System.Drawing.Size(99, 21);
            this.CB_IdSector.TabIndex = 46;
            this.CB_IdSector.taulaBD = "Sectors";
            this.CB_IdSector.ValueMember = "IdSector";
            // 
            // TB_IdFiliation
            // 
            this.TB_IdFiliation.CampoBD = "idFiliation";
            this.TB_IdFiliation.Enabled = false;
            this.TB_IdFiliation.Foranea = true;
            this.TB_IdFiliation.Llenar = false;
            this.TB_IdFiliation.Location = new System.Drawing.Point(632, 80);
            this.TB_IdFiliation.Name = "TB_IdFiliation";
            this.TB_IdFiliation.Size = new System.Drawing.Size(38, 20);
            this.TB_IdFiliation.TabIndex = 49;
            this.TB_IdFiliation.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_IdNatives
            // 
            this.TB_IdNatives.CampoBD = "idNatives";
            this.TB_IdNatives.Enabled = false;
            this.TB_IdNatives.Foranea = true;
            this.TB_IdNatives.Llenar = false;
            this.TB_IdNatives.Location = new System.Drawing.Point(439, 80);
            this.TB_IdNatives.Name = "TB_IdNatives";
            this.TB_IdNatives.Size = new System.Drawing.Size(38, 20);
            this.TB_IdNatives.TabIndex = 48;
            this.TB_IdNatives.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_IdSector
            // 
            this.TB_IdSector.CampoBD = "idSector";
            this.TB_IdSector.Enabled = false;
            this.TB_IdSector.Foranea = true;
            this.TB_IdSector.Llenar = false;
            this.TB_IdSector.Location = new System.Drawing.Point(438, 37);
            this.TB_IdSector.Name = "TB_IdSector";
            this.TB_IdSector.Size = new System.Drawing.Size(39, 20);
            this.TB_IdSector.TabIndex = 47;
            this.TB_IdSector.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "idFiliation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "idNatives";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "parsecs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "lat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "long";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "idSector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "DescPlanet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "CodePlanet";
            // 
            // TB_Parsecs
            // 
            this.TB_Parsecs.CampoBD = "parsecs";
            this.TB_Parsecs.Foranea = false;
            this.TB_Parsecs.Llenar = false;
            this.TB_Parsecs.Location = new System.Drawing.Point(204, 81);
            this.TB_Parsecs.Name = "TB_Parsecs";
            this.TB_Parsecs.Size = new System.Drawing.Size(100, 20);
            this.TB_Parsecs.TabIndex = 35;
            this.TB_Parsecs.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_Lat
            // 
            this.TB_Lat.CampoBD = "lat";
            this.TB_Lat.Foranea = false;
            this.TB_Lat.Llenar = false;
            this.TB_Lat.Location = new System.Drawing.Point(12, 81);
            this.TB_Lat.Name = "TB_Lat";
            this.TB_Lat.Size = new System.Drawing.Size(100, 20);
            this.TB_Lat.TabIndex = 34;
            this.TB_Lat.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_Long
            // 
            this.TB_Long.CampoBD = "long";
            this.TB_Long.Foranea = false;
            this.TB_Long.Llenar = false;
            this.TB_Long.Location = new System.Drawing.Point(570, 37);
            this.TB_Long.Name = "TB_Long";
            this.TB_Long.Size = new System.Drawing.Size(100, 20);
            this.TB_Long.TabIndex = 33;
            this.TB_Long.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_DescPlanet
            // 
            this.TB_DescPlanet.CampoBD = "DescPlanet";
            this.TB_DescPlanet.Foranea = false;
            this.TB_DescPlanet.Llenar = false;
            this.TB_DescPlanet.Location = new System.Drawing.Point(204, 37);
            this.TB_DescPlanet.Name = "TB_DescPlanet";
            this.TB_DescPlanet.Size = new System.Drawing.Size(100, 20);
            this.TB_DescPlanet.TabIndex = 32;
            this.TB_DescPlanet.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_CodePlanet
            // 
            this.TB_CodePlanet.CampoBD = "CodePlanet";
            this.TB_CodePlanet.Foranea = false;
            this.TB_CodePlanet.Llenar = false;
            this.TB_CodePlanet.Location = new System.Drawing.Point(12, 37);
            this.TB_CodePlanet.Name = "TB_CodePlanet";
            this.TB_CodePlanet.Size = new System.Drawing.Size(100, 20);
            this.TB_CodePlanet.TabIndex = 31;
            this.TB_CodePlanet.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // btn_Nou
            // 
            this.btn_Nou.BackColor = System.Drawing.Color.Gold;
            this.btn_Nou.Location = new System.Drawing.Point(67, -2);
            this.btn_Nou.Name = "btn_Nou";
            this.btn_Nou.Size = new System.Drawing.Size(100, 32);
            this.btn_Nou.TabIndex = 30;
            this.btn_Nou.Text = "NOU";
            this.btn_Nou.UseVisualStyleBackColor = false;
            // 
            // btn_updateDTG
            // 
            this.btn_updateDTG.BackColor = System.Drawing.Color.Gold;
            this.btn_updateDTG.Location = new System.Drawing.Point(-53, -2);
            this.btn_updateDTG.Name = "btn_updateDTG";
            this.btn_updateDTG.Size = new System.Drawing.Size(100, 32);
            this.btn_updateDTG.TabIndex = 29;
            this.btn_updateDTG.Text = "UPDATE";
            this.btn_updateDTG.UseVisualStyleBackColor = false;
            // 
            // dtgUsers
            // 
            this.dtgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(-68, 133);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.Size = new System.Drawing.Size(936, 320);
            this.dtgUsers.TabIndex = 28;
            // 
            // frm_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Base.Properties.Resources.kosmos_tumannost_zvezdy_7332;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.dtgUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Base";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboFK.ComboBoxFK CB_IdNatives;
        private ComboFK.ComboBoxFK CB_IdFiliation;
        private ComboFK.ComboBoxFK CB_IdSector;
        private CustomControls.SWTextBox TB_IdFiliation;
        private CustomControls.SWTextBox TB_IdNatives;
        private CustomControls.SWTextBox TB_IdSector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.SWTextBox TB_Parsecs;
        private CustomControls.SWTextBox TB_Lat;
        private CustomControls.SWTextBox TB_Long;
        private CustomControls.SWTextBox TB_DescPlanet;
        public CustomControls.SWTextBox TB_CodePlanet;
        private System.Windows.Forms.Button btn_Nou;
        private System.Windows.Forms.Button btn_updateDTG;
        private System.Windows.Forms.DataGridView dtgUsers;
    }
}