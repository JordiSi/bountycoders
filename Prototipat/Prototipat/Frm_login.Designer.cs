namespace Prototipat
{
    partial class Form_login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
			this.label3 = new System.Windows.Forms.Label();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.login = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(86, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password:";
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(174, 211);
			this.txt_password.Name = "txt_password";
			this.txt_password.Size = new System.Drawing.Size(100, 20);
			this.txt_password.TabIndex = 3;
			this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
			this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(174, 172);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(100, 20);
			this.txt_user.TabIndex = 2;
			this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
			this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(121, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "User:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(68, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(380, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login Secure Core";
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(305, 183);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(100, 32);
			this.login.TabIndex = 1;
			this.login.Text = "Log in";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.login_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(408, 281);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "No pulses este boton";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form_login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(539, 304);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.login);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form_login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button1;
    }
}

