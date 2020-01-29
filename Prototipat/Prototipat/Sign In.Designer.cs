namespace Prototipat
{
    partial class Sign_In
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
            this.Name_txt = new CustomControls.SWTextBox();
            this.Login_txt = new CustomControls.SWTextBox();
            this.Password_txt = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_signin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_txt
            // 
            this.Name_txt.CampoBD = null;
            this.Name_txt.Foranea = false;
            this.Name_txt.IdCombobox = null;
            this.Name_txt.Llenar = false;
            this.Name_txt.Location = new System.Drawing.Point(181, 56);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(154, 20);
            this.Name_txt.TabIndex = 0;
            this.Name_txt.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // Login_txt
            // 
            this.Login_txt.CampoBD = null;
            this.Login_txt.Foranea = false;
            this.Login_txt.IdCombobox = null;
            this.Login_txt.Llenar = false;
            this.Login_txt.Location = new System.Drawing.Point(181, 113);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(154, 20);
            this.Login_txt.TabIndex = 1;
            this.Login_txt.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // Password_txt
            // 
            this.Password_txt.CampoBD = null;
            this.Password_txt.Foranea = false;
            this.Password_txt.IdCombobox = null;
            this.Password_txt.Llenar = false;
            this.Password_txt.Location = new System.Drawing.Point(181, 170);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(154, 20);
            this.Password_txt.TabIndex = 2;
            this.Password_txt.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name";
            // 
            // btn_signin
            // 
            this.btn_signin.Location = new System.Drawing.Point(181, 207);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(154, 23);
            this.btn_signin.TabIndex = 9;
            this.btn_signin.Text = "Create User";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototipat.Properties.Resources.stars;
            this.ClientSize = new System.Drawing.Size(506, 259);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Login_txt);
            this.Controls.Add(this.Name_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sign_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In - BOUNTY CODERS";
            this.Load += new System.EventHandler(this.Sign_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox Name_txt;
        private CustomControls.SWTextBox Login_txt;
        private CustomControls.SWTextBox Password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_signin;
    }
}