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
            this.btn_Nou = new System.Windows.Forms.Button();
            this.btn_updateDTG = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nou
            // 
            this.btn_Nou.BackColor = System.Drawing.Color.Gold;
            this.btn_Nou.Location = new System.Drawing.Point(147, 31);
            this.btn_Nou.Name = "btn_Nou";
            this.btn_Nou.Size = new System.Drawing.Size(100, 32);
            this.btn_Nou.TabIndex = 30;
            this.btn_Nou.Text = "NOU";
            this.btn_Nou.UseVisualStyleBackColor = false;
            // 
            // btn_updateDTG
            // 
            this.btn_updateDTG.BackColor = System.Drawing.Color.Gold;
            this.btn_updateDTG.Location = new System.Drawing.Point(27, 31);
            this.btn_updateDTG.Name = "btn_updateDTG";
            this.btn_updateDTG.Size = new System.Drawing.Size(100, 32);
            this.btn_updateDTG.TabIndex = 29;
            this.btn_updateDTG.Text = "UPDATE";
            this.btn_updateDTG.UseVisualStyleBackColor = false;
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Location = new System.Drawing.Point(12, 166);
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
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.btn_Nou);
            this.Controls.Add(this.btn_updateDTG);
            this.Controls.Add(this.dtgUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Base";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btn_Nou;
        public System.Windows.Forms.Button btn_updateDTG;
        public System.Windows.Forms.DataGridView dtgUsers;
    }
}