namespace Prototipat
{
	partial class Form_principal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filiationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Prototipat.Properties.Resources.Star_destroyer_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1288, 848);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.BackgroundImage = global::Prototipat.Properties.Resources.stars;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.opcio1ToolStripMenuItem,
            this.filiationsToolStripMenuItem,
            this.regionsToolStripMenuItem,
            this.sectorsToolStripMenuItem,
            this.routesToolStripMenuItem,
            this.routeTypesToolStripMenuItem,
            this.speciesToolStripMenuItem,
            this.userCategoriesToolStripMenuItem,
            this.userRanksToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.sortirToolStripMenuItem,
            this.fTPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1288, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.loginToolStripMenuItem.Text = "Logout";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // opcio1ToolStripMenuItem
            // 
            this.opcio1ToolStripMenuItem.Checked = true;
            this.opcio1ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opcio1ToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcio1ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.opcio1ToolStripMenuItem.Name = "opcio1ToolStripMenuItem";
            this.opcio1ToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.opcio1ToolStripMenuItem.Text = "Planets";
            this.opcio1ToolStripMenuItem.Click += new System.EventHandler(this.planetesToolStripMenuItem_Click);
            // 
            // filiationsToolStripMenuItem
            // 
            this.filiationsToolStripMenuItem.Checked = true;
            this.filiationsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filiationsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filiationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.filiationsToolStripMenuItem.Name = "filiationsToolStripMenuItem";
            this.filiationsToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.filiationsToolStripMenuItem.Text = "Filiations";
            this.filiationsToolStripMenuItem.Click += new System.EventHandler(this.filiationsToolStripMenuItem_Click);
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Checked = true;
            this.regionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.regionsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.regionsToolStripMenuItem.Text = "Regions";
            this.regionsToolStripMenuItem.Click += new System.EventHandler(this.regionsToolStripMenuItem_Click);
            // 
            // sectorsToolStripMenuItem
            // 
            this.sectorsToolStripMenuItem.Checked = true;
            this.sectorsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sectorsToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sectorsToolStripMenuItem.Name = "sectorsToolStripMenuItem";
            this.sectorsToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.sectorsToolStripMenuItem.Text = "Sectors";
            this.sectorsToolStripMenuItem.Click += new System.EventHandler(this.sectorsToolStripMenuItem_Click);
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.Checked = true;
            this.routesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.routesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.routesToolStripMenuItem.Text = "Routes";
            this.routesToolStripMenuItem.Click += new System.EventHandler(this.routesToolStripMenuItem_Click);
            // 
            // routeTypesToolStripMenuItem
            // 
            this.routeTypesToolStripMenuItem.Checked = true;
            this.routeTypesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.routeTypesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeTypesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.routeTypesToolStripMenuItem.Name = "routeTypesToolStripMenuItem";
            this.routeTypesToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.routeTypesToolStripMenuItem.Text = "RouteTypes";
            this.routeTypesToolStripMenuItem.Click += new System.EventHandler(this.routeTypesToolStripMenuItem_Click);
            // 
            // speciesToolStripMenuItem
            // 
            this.speciesToolStripMenuItem.Checked = true;
            this.speciesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.speciesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.speciesToolStripMenuItem.Name = "speciesToolStripMenuItem";
            this.speciesToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.speciesToolStripMenuItem.Text = "Species";
            this.speciesToolStripMenuItem.Click += new System.EventHandler(this.speciesToolStripMenuItem_Click);
            // 
            // userCategoriesToolStripMenuItem
            // 
            this.userCategoriesToolStripMenuItem.Checked = true;
            this.userCategoriesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userCategoriesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCategoriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userCategoriesToolStripMenuItem.Name = "userCategoriesToolStripMenuItem";
            this.userCategoriesToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.userCategoriesToolStripMenuItem.Text = "UserCategories";
            this.userCategoriesToolStripMenuItem.Click += new System.EventHandler(this.userCategoriesToolStripMenuItem_Click);
            // 
            // userRanksToolStripMenuItem
            // 
            this.userRanksToolStripMenuItem.Checked = true;
            this.userRanksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.userRanksToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRanksToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.userRanksToolStripMenuItem.Name = "userRanksToolStripMenuItem";
            this.userRanksToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.userRanksToolStripMenuItem.Text = "UserRanks";
            this.userRanksToolStripMenuItem.Click += new System.EventHandler(this.userRanksToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Checked = true;
            this.usersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(56, 27);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.sortirToolStripMenuItem.Text = "Exit";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fTPToolStripMenuItem
            // 
            this.fTPToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fTPToolStripMenuItem.Name = "fTPToolStripMenuItem";
            this.fTPToolStripMenuItem.Size = new System.Drawing.Size(57, 27);
            this.fTPToolStripMenuItem.Text = "FTP";
            this.fTPToolStripMenuItem.Click += new System.EventHandler(this.fTPToolStripMenuItem_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 881);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - BOUNTY CODERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem opcio1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filiationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fTPToolStripMenuItem;
    }
}